using System;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using Microsoft.AppCenter.Distribute;
using Microsoft.AppCenter.Push;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace AppCenterSample
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var mainPage = new MainPage();
            var navPage = new NavigationPage(mainPage);
            navPage.BarTextColor = Color.White;
            MainPage = navPage;

            NavigationPage.SetHasNavigationBar(mainPage, false);
        }

        protected override void OnStart()
        {
#error Please set your iOS and Android keys here from AppCenter.ms
            AppCenter.Start("ios=<Your iOS Key>;" +
                            "android=<Your Android Key>",
                            typeof(Distribute), 
                            typeof(Crashes), 
                            typeof(Analytics), 
                            typeof(Push));
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
