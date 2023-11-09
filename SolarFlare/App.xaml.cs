using SolarFlare.Views;

namespace SolarFlare
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new paginaLogin());
        }
    }
}