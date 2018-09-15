using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Assignment2.ViewModels
{
    public class BookCell : ViewCell
    {
        public BookCell()
        {
            var label = new Label
            {
                VerticalTextAlignment = TextAlignment.Center
            };
            label.SetBinding(Label.TextProperty, "Name");

            var tick = new Image
            {
                Source = ImageSource.FromFile("check.png"),
            };
            tick.SetBinding(VisualElement.IsVisibleProperty, "Switch to Mark as your favorite");

            var layout = new StackLayout
            {
                Padding = new Thickness(20, 0, 0, 0),
                Orientation = StackOrientation.Horizontal,
                HorizontalOptions = LayoutOptions.StartAndExpand,
                Children = { label, tick }
            };
            View = layout;
        }
    }
}
