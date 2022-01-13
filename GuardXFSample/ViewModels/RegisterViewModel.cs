using System.Windows.Input;
using GuardXFSample.Models;
using Xamarin.Forms;

namespace GuardXFSample.ViewModels
{
    public sealed class RegisterViewModel
    {
        public ICommand CreateUserCommand { get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }

        public RegisterViewModel()
        {
            CreateUserCommand = new Command(() =>
            {
                var user = new User(FirstName, LastName, Email, Age);
                App.Current.MainPage.DisplayAlert("Yayy", "User created", "Ok");
            });
        }
    }
}
