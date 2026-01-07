using Wellness_Wizards_App.Models; // Make sure this matches the namespace where your DeckModel is defined
using Wellness_Wizards_App.ViewModels; // Adjust to the namespace of your CardsViewModel

namespace Wellness_Wizards_App
{
    public partial class CardsPage : ContentPage
    {
        public CardsPage()
        {
            InitializeComponent();   
        }

        // Event handler for selection changes in the CollectionView
        private async void OnDeckSelected(object sender, EventArgs e)
        {
            var tapEventArgs = e as TappedEventArgs;
            if (tapEventArgs?.Parameter is DeckModel selectedDeck)
            {
                // Navigate to the CardsDetailPage, passing the selected DeckModel to its constructor
                await Navigation.PushAsync(new CardsDetailPage(selectedDeck.Cards, selectedDeck.Name));
            }
        }

        private async void OnAddDeck(object sender, EventArgs e)
        {
            //Navigate to new page to request new deck
            var popUpPage = new CreateNewDeckTemplate();
            await Navigation.PushModalAsync(popUpPage);
        }
    }
}