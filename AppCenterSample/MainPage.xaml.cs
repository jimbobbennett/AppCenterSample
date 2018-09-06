using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using Xamarin.Forms;

namespace AppCenterSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public void SendEventClicked(object sender, EventArgs e)
        {
            Analytics.TrackEvent("Event", new Dictionary<string, string> { { "Source", "Birmingham" } });
        }

        public void SendCrashClick(object sender, EventArgs e)
        {
            Crashes.GenerateTestCrash();
        }

        int number;
        public void ChangeNumberClick(object sender, EventArgs e)
        {
            number++;
            NumberLabel.Text = $"Number: {number}";
        }
    }
}
