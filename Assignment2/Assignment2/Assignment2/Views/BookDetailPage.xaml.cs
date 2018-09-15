using Assignment2.Models;
using Assignment2.ViewModels;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Assignment2.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class BookDetailPage : ContentPage  
	{
        BookDetailViewModel viewModel;
        public BookDetailPage(BookDetailViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = this.viewModel = viewModel;
        }

        public BookDetailPage()
        {
            InitializeComponent();

            var item = new Item
            {
                Text = "Item 1",
                Description = "This is an item description."
            };

            viewModel = new BookDetailViewModel(item);
            BindingContext = viewModel;
        }

        async void Save_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BookShelfListPage());
        }

        async void OnLogOutButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Login());
        }
    }
}