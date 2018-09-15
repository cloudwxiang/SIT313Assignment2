using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Assignment2.Models;

namespace Assignment2.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class BookShelfListPage : ContentPage
    {
            public BookShelfListPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            listView.ItemsSource = App.Database.GetItems();
        }

        async void OnItemAdded(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BookShelfPage
            {
                BindingContext = new Item()
            });
        }

        async void OnListItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new BookShelfPage
                {
                    BindingContext = e.SelectedItem as Item
                });
            }
        }
    }
}