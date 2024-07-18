using CommunityToolkit.Mvvm.ComponentModel;

namespace SampleApp
{
    internal class MainViewModel : ObservableObject
    {
        public MainViewModel()
        {
        }

        public List<View> ControlsToShow
        {
            get
            {
                List<View> views = new();

                views.Add(new Button { Text = "Greetings", VerticalOptions = LayoutOptions.Center });
                views.Add(new Button { Text = "Salutations", VerticalOptions = LayoutOptions.Center });
                views.Add(new Button { Text = "Bonjour", VerticalOptions = LayoutOptions.Center });
                views.Add(new Entry { Text = "Ciao", VerticalOptions = LayoutOptions.Center });
                views.Add(new Button { Text = "Namaste", VerticalOptions = LayoutOptions.Center });
                views.Add(new Label { Text = "Konnichiwa", VerticalOptions = LayoutOptions.Center, VerticalTextAlignment = TextAlignment.Center });
                views.Add(new Entry { Text = "Hallo", VerticalOptions = LayoutOptions.Center });
                views.Add(new Button { Text = "Hej", VerticalOptions = LayoutOptions.Center });
                views.Add(new Entry { Text = "Merhaba", VerticalOptions = LayoutOptions.Center });
                views.Add(new Label { Text = "Szia", VerticalOptions = LayoutOptions.Center, VerticalTextAlignment = TextAlignment.Center });
                views.Add(new Entry { Text = "Olá", VerticalOptions = LayoutOptions.Center });
                views.Add(new Button { Text = "Privet", VerticalOptions = LayoutOptions.Center });
                views.Add(new Entry { Text = "Guten Tag", VerticalOptions = LayoutOptions.Center });
                views.Add(new Label { Text = "Sawubona", VerticalOptions = LayoutOptions.Center, VerticalTextAlignment = TextAlignment.Center });
                views.Add(new Entry { Text = "Annyeonghaseyo", VerticalOptions = LayoutOptions.Center });
                views.Add(new Button { Text = "Salam", VerticalOptions = LayoutOptions.Center });
                views.Add(new Entry { Text = "Marhaba", VerticalOptions = LayoutOptions.Center });
                views.Add(new Label { Text = "Sveiki", VerticalOptions = LayoutOptions.Center, VerticalTextAlignment = TextAlignment.Center });
                views.Add(new Entry { Text = "Ahoj", VerticalOptions = LayoutOptions.Center });
                views.Add(new Button { Text = "Sain baina uu", VerticalOptions = LayoutOptions.Center });
                views.Add(new Entry { Text = "Szia", VerticalOptions = LayoutOptions.Center });
                views.Add(new Label { Text = "Zdravo", VerticalOptions = LayoutOptions.Center, VerticalTextAlignment = TextAlignment.Center });
                views.Add(new Entry { Text = "Salut", VerticalOptions = LayoutOptions.Center });

                return views;

            }
        }
    }
}
