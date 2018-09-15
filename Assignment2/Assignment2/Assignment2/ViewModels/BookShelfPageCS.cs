using Assignment2.Models;
using Assignment2.Resx;
using Xamarin.Forms;

namespace Assignment2.ViewModels
{
    public class BookShelfPageCS : ContentPage
    {
        public BookShelfPageCS()
        {
            FlowDirection = Device.FlowDirection;

            this.SetBinding(Page.TitleProperty, "Name");

            NavigationPage.SetHasNavigationBar(this, true);
            var nameLabel = new Label(); // no Text! localized later
            var nameEntry = new Entry();

            nameEntry.SetBinding(Entry.TextProperty, "Name");

            var notesLabel = new Label(); // no Text! localized later
            var notesEntry = new Entry();
            notesEntry.SetBinding(Entry.TextProperty, "Notes");

            var doneLabel = new Label(); // no Text! localized later
            var doneEntry = new Switch();
            doneEntry.SetBinding(Switch.IsToggledProperty, "Done");

            var saveButton = new Button(); // no Text! localized later
            saveButton.Clicked += async (sender, e) =>
            {
                var item = (Item)BindingContext;
                App.Database.SaveItem(item);
                await Navigation.PopAsync();
            };

            var deleteButton = new Button(); // no Text! localized later
            deleteButton.Clicked += async (sender, e) =>
            {
                var item = (Item)BindingContext;
                App.Database.DeleteItem(item.Id);
                await Navigation.PopAsync();
            };

            var cancelButton = new Button(); // no Text! localized later
            cancelButton.Clicked += async (sender, e) =>
            {
                await Navigation.PopAsync();
            };

            // TODO: Forms Localized text using two different methods:

            // refer to the codebehind for AppResources.resx.designer
            nameLabel.Text = AppResources.NameLabel;
            notesLabel.Text = AppResources.NotesLabel;
            doneLabel.Text = AppResources.DoneLabel;

            // using ResourceManager
            saveButton.Text = AppResources.SaveButton;
            deleteButton.Text = L10n.Localize("DeleteButton", AppResources.Culture);
            cancelButton.Text = L10n.Localize("CancelButton", AppResources.Culture);

            Content = new StackLayout
            {
                Margin = new Thickness(20),
                Children = {
                    nameLabel, nameEntry,
                    notesLabel, notesEntry,
                    doneLabel, doneEntry,
                    saveButton, deleteButton, cancelButton
                }
            };
        }
    }
}
