
namespace Module03Exercise01.View
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private async void OnLoginClicked(object sender, EventArgs e)
        {
       
            await Navigation.PushAsync(new EmployeePage());
        }
    }
}
