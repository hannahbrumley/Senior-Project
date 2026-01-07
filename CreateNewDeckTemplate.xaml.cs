namespace Wellness_Wizards_App;

public partial class CreateNewDeckTemplate : ContentPage
{
	public CreateNewDeckTemplate()
	{
		InitializeComponent();
	}

    private async void OnCloseClicked(object sender, EventArgs e)
    {
        // Close the pop-up page
        await Navigation.PopModalAsync();
    }
}