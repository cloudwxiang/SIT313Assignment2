using Assignment2.Models;
using Assignment2.Resx;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Assignment2.ViewModels
{
    public class BookShelfListCS : ContentPage
    {
        ListView listView;
        public BookShelfListCS()
        {
            FlowDirection = Device.FlowDirection;

            Title = AppResources.ApplicationTitle;

            listView = new ListView { RowHeight = 40 };
            listView.ItemTemplate = new DataTemplate(typeof(BookCell));

            listView.ItemSelected += async (sender, e) =>
            {
                await Navigation.PushAsync(new BookShelfPageCS
                {
                    BindingContext = (Item)e.SelectedItem
                });
            };

            var layout = new StackLayout { Margin = new Thickness(20) };
            layout.Children.Add(listView);
            Content = layout;

            var tbiAdd = new ToolbarItem("Add", "plus.png", () =>
            {
                var item = new Item();
                var todoPage = new BookShelfPageCS();
                todoPage.BindingContext = item;
                Navigation.PushAsync(todoPage);
            }, 0, 0);

            ToolbarItems.Add(tbiAdd);

        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            listView.ItemsSource = App.Database.GetItems();
        }
    }
}
