using Hello_Cotto_Learning.Services;
using Hello_Cotto_Learning.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Hello_Cotto_Learning
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
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
