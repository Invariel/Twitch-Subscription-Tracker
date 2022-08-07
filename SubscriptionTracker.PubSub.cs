using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitchLib.PubSub.Events;

namespace Subscription_Tracker
{
    public partial class SubscriptionTracker : Form
    {
        public async void Connect(object? sender, EventArgs e)
        {
            if (!_connected)
            {
                _twitchAPI = new TwitchLib.Api.TwitchAPI();
                _twitchAPI.Settings.ClientId = ClientId;
                _twitchAPI.Settings.AccessToken = _settings.AccessToken;

                string channelId;

                try
                {
                    var users = await _twitchAPI.Helix.Users.GetUsersAsync(null, new List<string> { _settings.ChannelName }, _settings.AccessToken);

                    if (users.Users.Length > 0)
                    {
                        channelId = users.Users[0].Id;
                    }
                    else
                    {
                        MessageBox.Show($"No channel found with the name {_settings.ChannelName}", "Channel not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                catch (Exception)
                {
                    if (MessageBox.Show("Unable to talk with the Twitch API.  Get a new access token by clicking \"Yes\" below and put that into the AccessToken field in appsettings.json", "Unable to Authenticate to Twitch", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                    {
                        System.Diagnostics.Process.Start(
                            new System.Diagnostics.ProcessStartInfo
                            {
                                FileName = $"https://api.twitch.tv/kraken/oauth2/authorize?client_id={ClientId}&redirect_uri={OauthRedirect}&response_type=token&scope={Scopes}",
                                UseShellExecute = true
                            });
                    }

                    return;
                }

                _pubSub = new TwitchLib.PubSub.TwitchPubSub();

                _pubSub.OnPubSubServiceConnected += delegate
                {
                    _pubSub.ListenToSubscriptions(channelId);

                    this.Invoke((Action)(() => lbl_Connected.Text = $"Connected for {_settings.ChannelName}"));
                };

                _pubSub.OnPubSubServiceClosed += delegate
                {
                    _pubSub.Connect();
                    this.Invoke((Action)(() => lbl_Connected.Text = $"Disconnected."));
                };

                _pubSub.OnPubSubServiceError += delegate
                {
                    _pubSub.Connect();
                    this.Invoke((Action)(() => lbl_Connected.Text = $"Disconnected."));
                };

                _pubSub.OnChannelSubscription += AddSubPoints;

                _pubSub.Connect();
            }
        }

        public async void AddSubPoints(object? sender, OnChannelSubscriptionArgs args)
        {
            decimal pointsToAdd = 0.0M;

            switch (args.Subscription.SubscriptionPlan)
            {
                case TwitchLib.PubSub.Enums.SubscriptionPlan.Prime:
                    pointsToAdd = numud_Prime.Value;
                    break;
                case TwitchLib.PubSub.Enums.SubscriptionPlan.Tier1:
                    pointsToAdd = numud_TierOne.Value;
                    break;
                case TwitchLib.PubSub.Enums.SubscriptionPlan.Tier2:
                    pointsToAdd = numud_TierTwo.Value;
                    break;
                case TwitchLib.PubSub.Enums.SubscriptionPlan.Tier3:
                    pointsToAdd = numud_TierThree.Value;
                    break;
            }

            _subPoints += (int)pointsToAdd;

            _fileStreamUpdater.WriteFile(_subPoints.ToString());
        }
    }
}
