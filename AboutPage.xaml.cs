using Mopups.Services;

namespace Wellness_Wizards_App
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }

        private bool isOriginalImage = true;
        public async void OnAdminMenuClicked(object sender, EventArgs e)
        {

            /*        // Reference to the image button that was clicked
                        var imageButton = sender as ImageButton;

                        if (imageButton != null)
                        {
                            // Switch the image source based on the current state
                            if (isOriginalImage)
                            {
                                // Set the source to the alternative image
                                imageButton.Source = "gold_dot_icon.png";
                            }
                            else
                            {
                                // Set the source back to the original image
                                imageButton.Source = "flipped_dot_icon.png";
                            }

                            // Toggle the flag to reflect the change
                            isOriginalImage = !isOriginalImage;
                        }*/

            await MopupService.Instance.PushAsync(new LoginPage());
        }
    }
}