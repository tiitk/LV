using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LV
{
    public partial class LVPage : ContentPage
    {
        static bool first = true;
        public LVPage()
        {
            InitializeComponent();
            if (first)
            {
                pop_btn.IsEnabled = false;
                first = false;
            }                
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

        async void OnPushClicked(object sender, EventArgs args)
        {
            var newPage = new LVPage();
            await Nav.Push(newPage);
            
        }

        async void OnPopClicked(object sender, EventArgs args)
        {
            await Nav.Pop();
            //EnablePopButton();
        }

        void EnablePopButton()
        {
            if (Nav.Navigation.NavigationStack.Count > 1)
                pop_btn.IsEnabled = true;
            else
                pop_btn.IsEnabled = false;
        }

        public void Cleanup()
        {
            BindingContext = null;
            stack.Children.Clear();
            Content = null;            
        }
    }
}
