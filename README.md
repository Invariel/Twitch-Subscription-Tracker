# Subscription Tracker

- Simple, customizeable subscription point tracker for Twitch.
- Tracks new subs, resubs, gift subs, and Twitch Prime subs.
- Allows you to set the point values for each of Twitch Prime, tier one, tier two, and tier three subscriptions.
- Writes point values to a simple text file that can be read by OBS (or not, that's up to you).
- Great for subathons and events.

# First Time Setup
- Open appsettings.json, and enter your Twitch username as the ChannelName value.
- Run the program, and click Connect.  It will fail.
- Click "Yes" to be redirected to Twitch to give the application access.
- You will be taken to a page that has your Access Token.  Enter that as the AccessToken value in appsettings.json
- Close and restart
- Click Connect.  Subscription points will be written to the file that was specified as Filename.
