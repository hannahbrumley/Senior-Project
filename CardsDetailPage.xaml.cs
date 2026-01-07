using System.Collections.ObjectModel;
using Wellness_Wizards_App.Models;
using Wellness_Wizards_App.ViewModels;

namespace Wellness_Wizards_App;

public partial class CardsDetailPage : ContentPage
{
    private readonly CardsDetailPageViewModel _viewModel;

    public CardsDetailPage(ObservableCollection<CardModel> cards, string deckName)
    {
        InitializeComponent();
        _viewModel = new CardsDetailPageViewModel(cards, deckName);
        BindingContext = _viewModel;
        PopulateCardPicker();
    }
    private void PopulateCardPicker()
    {
        CardPicker.Items.Clear(); // Clear existing items

        for (int i = 0; i < _viewModel.Cards.Count; i++)
        {
            CardPicker.Items.Add($"{i + 1}. {_viewModel.Cards[i].Title}");
        }
    }
    private void OnPreviousClicked(object sender, EventArgs e)
    {
        if (_viewModel.CurrentIndex > 0)
        {
            _viewModel.CurrentIndex--;
            _viewModel.DisplayCurrentCard();
        }
    }

    private void OnNextClicked(object sender, EventArgs e)
    {
        if (_viewModel.CurrentIndex < _viewModel.Cards.Count - 1)
        {
            _viewModel.CurrentIndex++;
        }
        _viewModel.DisplayCurrentCard();
    }

    private void OnCardSelected(object sender, EventArgs e)
    {
        if (CardPicker.SelectedIndex != -1)
        {
            _viewModel.CurrentIndex = CardPicker.SelectedIndex;
            _viewModel.DisplayCurrentCard();
        }
    }

    private async void OnAddCard(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CreateNewCardTemplate());
    }

    private async void ImageButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}