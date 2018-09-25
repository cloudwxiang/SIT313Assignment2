using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Assignment2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BookStore : ContentPage
    {
        public BookStore()
        {
            InitializeComponent();
        }

        async void OnLogOutButtonClicked(object sender, EventArgs e)
        {
            App.IsUserLoggedIn = false;
            Navigation.InsertPageBefore(new Login(), this);
            await Navigation.PopAsync();
        }

        async void OnBooksButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BookStorePage());
        }

        async void OnMyBookShelfButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BookShelfListPage());
        }
        
        private void Button_Clicked(object sender, EventArgs e)
        {
            var url = "https://moker-admin.com/api/test/words.php";
            Device.OpenUri(new Uri(url));
        }
    }
}
