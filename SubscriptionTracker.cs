using Microsoft.Extensions.Configuration;
using TwitchLib;
using TwitchLib.Api;
using TwitchLib.Api.Helix;
using TwitchLib.PubSub;

namespace Subscription_Tracker
{
    public partial class SubscriptionTracker : Form
    {
        private string ClientId = "0cgrq71k4abv54nz2f1j75hlmicake";
        private string OauthRedirect = "https://invariel.ca/webauth/subscription_tracker_auth.html";
        private string Scopes = "channel:read:subscriptions";

        private bool _connected = false;
        private int _subPoints = 0;

        private TwitchAPI _twitchAPI;
        private TwitchPubSub _pubSub;

        private Settings _settings = new Settings();
        private FileStreamUpdater _fileStreamUpdater;

        public SubscriptionTracker()
        {
            IConfigurationBuilder builder = new ConfigurationBuilder().AddJsonFile("appsettings.json");
            IConfiguration configuration = builder.Build();
            configuration.Bind("Settings", _settings);

            InitializeComponent();

            btn_Connect.Click += Connect;

            string points = "0";

            _fileStreamUpdater = new FileStreamUpdater(_settings.Filename);
            points = _fileStreamUpdater.ReadFile();

            int.TryParse(points, out _subPoints);

            this.FormClosed += CloseFileStream;
            this.FormClosing += CloseFileStream;
        }

        public void CloseFileStream (object? sender, EventArgs e)
        {
            _fileStreamUpdater.Dispose();
        }
    }
}