# AppCenter Sample

This is a demo app to show off [AppCenter](https://appcenter.ms/?WT.mc_id=appcenter-github-jabenn).
You can read more on AppCenter in [the docs](aka.ms/AppCtr).

## Configuring the app

* Create two apps in AppCenter - an iOS Xamarin app and an Android Xamarin app.
* Add the API keys for each one to [`App.xaml.cs`](./AppCenterSample/App.xaml.cs).
* Add your iOS API key to the [`info.plist`](./AppCenterSample.iOS/Info.plist) file.
* Run the app.

The __Send Event__ button will send an event to AppCenter.
The __Send Crash__ button will crash the app. Re-launch it to send a crash to AppCenter.

In-app updates are supported, so to test this out set up a build and distribute it to your device. Then increment the version and distribute again to get the in-app update notification.

The __Change the number__ button is for the UI tests. You can set these up in AppCenter Test as a UI test to run.
