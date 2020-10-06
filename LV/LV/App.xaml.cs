using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LV
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            var np = new NavigationPage(new LVPage());
            Nav.Navigation = np.Navigation;
            MainPage = np;
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
