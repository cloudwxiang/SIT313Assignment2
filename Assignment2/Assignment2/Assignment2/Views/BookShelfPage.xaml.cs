using Assignment2.Models;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Assignment2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BookShelfPage : ContentPage
    {
        public BookShelfPage()
        {
            InitializeComponent();
        }
        
        async void OnSave(object s, EventArgs e)
        {
            var item = (Item)BindingContext;
            App.Database.SaveItem(item);
            await Navigation.PopAsync();
        }

        async void OnDelete(object s, EventArgs e)
        {
            var item = (Item)BindingContext;
            App.Database.DeleteItem(item.Id);
            await Navigation.PopAsync();
        }

        async void OnCancel(object s, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}