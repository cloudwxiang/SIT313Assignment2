using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Assignment2.Views;
using Assignment2.Data;
using System.IO;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Assignment2
{
    public partial class App : Application
    {
        public static bool IsUserLoggedIn { get; set; }
        static ItemDatabase database;
        public App()
        {
            if (!IsUserLoggedIn)
            {
                MainPage = new NavigationPage(new Login());
            }
            else
            {
                MainPage = new NavigationPage(new Assignment2.Views.BookStore());
            }
        }

        public static ItemDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new ItemDatabase();
                }
                return database;
            }
        }

        public int ResumeAtId { get; set; }

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
