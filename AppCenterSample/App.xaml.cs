using System;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using Microsoft.AppCenter.Distribute;
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
            AppCenter.Start("ios=acee40cf-58cd-421c-a4f5-dba0683a4df9;" +
                            "android=68132a34-9578-4a61-bf5c-fbd10ca6f9cc",
                            typeof(Analytics), typeof(Crashes), typeof(Distribute));
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
