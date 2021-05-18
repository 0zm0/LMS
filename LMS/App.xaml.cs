using LMS.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LMS
{

    public partial class App : Application
    {

        public static string dbPath = string.Empty;
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new LoginScreen());
        }

        public App(string _dbPath)
        {
            InitializeComponent();
            dbPath = _dbPath;
            MainPage = new NavigationPage(new LoginScreen());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
