using GuardXFSample.ViewModels;
using Xamarin.Forms;

namespace GuardXFSample.Views
{
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
            BindingContext = new RegisterViewModel();
        }
    }
}
