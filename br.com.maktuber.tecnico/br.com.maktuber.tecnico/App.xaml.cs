using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using br.com.maktuber.tecnico.Services;
using br.com.maktuber.tecnico.Views;

namespace br.com.maktuber.tecnico
{
    public partial class App : Application
    {
        public static double ScreenWidth;
        public static double ScreenHeight;

        public App()
        {
            InitializeComponent();
            XF.Material.Forms.Material.Init(this,"Material.Configuration");
#if DEBUG
            HotReloader.Current.Run(this);
#endif

            DependencyService.Register<MockDataStore>();
            MainPage = new  NavigationPage( new MainPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
            MainPage= new NavigationPage(new Intro());
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
