//using AudioUnit;
using Wellness_Wizards_App.Models;

namespace Wellness_Wizards_App;

public partial class CreateNewCardTemplate : ContentPage
{
    

    public CreateNewCardTemplate()
	{
		InitializeComponent();
	}

    
    //OnAddToDeck, card submission will pop up
    private async void OnAddToDeck(object sender, EventArgs e) {

        //Allows context of card, title, and text to be sent 
        if (Email.Default.IsComposeSupported)
        {   
            string subject = "Wellness Card Submission";
            string body = "Title: " + Title.Text + "\n" + "Body: " + Body.Text;
            string[] recipients = new[] { "chichijo14@gmail.com" };

            var message = new EmailMessage
            {
                Subject = subject,
                Body = body,
                BodyFormat = EmailBodyFormat.PlainText,
                To = new List<string>(recipients)
            };

            await Email.Default.ComposeAsync(message);
        }

        await DisplayAlert("New card submission", "Thank you. Your submission had been sent to Suspenders4Hope Team for considerations.", "OK");

        await Navigation.PopAsync();

       
    }

    private async void GoBackButton(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}