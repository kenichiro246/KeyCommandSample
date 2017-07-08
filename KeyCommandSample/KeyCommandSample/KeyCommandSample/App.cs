using Xamarin.Forms;

namespace KeyCommandSample
{
    public class App : Application
    {
        public App()
        {
            MainPage = new KeyCommandSample.Page1();
            //MainPage = new Menu();
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
