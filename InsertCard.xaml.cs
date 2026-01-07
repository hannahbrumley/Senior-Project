namespace Wellness_Wizards_App;

//using AndroidX.Lifecycle;
using System.Collections.ObjectModel;
using Wellness_Wizards_App.Models;
using Wellness_Wizards_App.ViewModels;

public partial class InsertCard : ContentPage
{
    private string selectedDeck;
    private int selectedIndex;

    CardsViewModel viewModel;
    public InsertCard()
    {
        InitializeComponent();
        viewModel = (CardsViewModel)BindingContext;

    }

   
    void OnPickerSelectedIndexChanged(object sender, EventArgs e)
    {
        var picker = (Picker)sender;
        selectedIndex = picker.SelectedIndex;

        if (selectedIndex != -1)
        {
            selectedDeck = (string)picker.Items[selectedIndex];
        }
    }

    private void OnAddToDeck(object sender, EventArgs e)
    {
        ObservableCollection<DeckModel> decks = viewModel.Decks;

        decks[selectedIndex].Cards.Add(
             new CardModel
             {
                 //Number = decks[selectedIndex].Cards.Count + 1,
                 Title = Title.Text,
                 //Body = Body.Text

             }

            );

        DisplayAlert("Card added", "New card has been added to " + decks[selectedIndex].Name, "OK");

        Navigation.PopAsync();
        

    }
}