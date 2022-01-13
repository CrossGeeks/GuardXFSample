using GuardXFSample.Views;
using Xamarin.Forms;

namespace GuardXFSample
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new RegisterPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
