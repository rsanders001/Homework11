using Xamarin.Forms;

namespace Todo
{
    public class TodoItemPageCS : ContentPage
    {
        public TodoItemPageCS()
        {
            Title = "Jokes";

            var jokeEntry = new Entry();
            jokeEntry.SetBinding(Entry.TextProperty, "Joke");

            var doneSwitch = new Switch();
            doneSwitch.SetBinding(Switch.IsToggledProperty, "Done");

            var saveButton = new Button { Text = "Save" };
            saveButton.Clicked += async (sender, e) =>
            {
                var todoItem = (TodoItem)BindingContext;
                await App.Database.SaveItemAsync(todoItem);
                await Navigation.PopAsync();
            };

            

            Content = new StackLayout
            {
                Margin = new Thickness(20),
                VerticalOptions = LayoutOptions.StartAndExpand,
                Children =
                {
                    new Label { Text = "Joke" },
                    jokeEntry,
                    new Label { Text = "Done" },
                    doneSwitch,
                    saveButton,
                }
            };
        }
    }
}
