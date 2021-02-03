using System;
using System.Diagnostics;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GoStyle
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
            Debug.WriteLine("start");
            if (Current.Properties.ContainsKey("MainPageID"))
            {
                var id = Current.Properties["MainPageID"];
                Debug.WriteLine("start - " + id);
            }
        }

        protected override void OnSleep()
        {
            Debug.WriteLine("sleep");
        }

        protected override void OnResume()
        {
            Debug.WriteLine("resume");
            if (Current.Properties.ContainsKey("MainPageID"))
            {
                var id = Current.Properties["MainPageID"];
                Debug.WriteLine("resume - " + id);
            }
        }
    }
}
