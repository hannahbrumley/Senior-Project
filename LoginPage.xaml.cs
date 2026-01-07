using Wellness_Wizards_App.ViewModels;

namespace Wellness_Wizards_App
{

    public partial class LoginPage
    {
        private AdminLoginViewModel ViewModel => BindingContext as AdminLoginViewModel;

        public LoginPage()
        {
            InitializeComponent();
            CheckTimerState();
        }

        private void CheckTimerState()
        {
            ViewModel?.CheckInitialLockStatus();
        }

        private void OnCodeButtonPressed(object sender, EventArgs e)
        {
            CodeButton.BackgroundColor = Color.Parse("#FFDA55");
        }

        private void OnCodeButtonReleased(object sender, EventArgs e)
        {
            CodeButton.BackgroundColor = Application.Current.Resources["AppAccentMain"] as Color;
        }
    }
}
