using System;
using System.Collections.ObjectModel;
using Assignment2.Models;
using Assignment2.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Assignment2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BookStorePage : ContentPage
    {
        BooksViewModel viewModel;

        public BookStorePage()
        {
            InitializeComponent();

            BindingContext = viewModel = new BooksViewModel();
        }

        async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            var item = args.SelectedItem as Item;
            if (item == null)
                return;

            await Navigation.PushAsync(new BookDetailPage(new BookDetailViewModel(item)));

            // Manually deselect item.
            ItemsListView.SelectedItem = null;
        }

        async void OnLogOutButtonClicked(object sender, EventArgs e)
        {
            App.IsUserLoggedIn = false;
            Navigation.InsertPageBefore(new Login(), this);
            await Navigation.PopAsync();
        }
    }
}
