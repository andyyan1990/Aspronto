using Xamarin.Forms;

namespace Aspronto
{
    public partial class App : Application
    {
        public static string DatabaseLocation = string.Empty;
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new WelcomePage());
        }

        public App(string databaseLoction)
        {
            InitializeComponent();

            DatabaseLocation = databaseLoction;

            MainPage = new NavigationPage(new WelcomePage());
            //MainPage = new WelcomePage();

        }

        protected override void OnStart()
        {
            // Handle when your app starts
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
