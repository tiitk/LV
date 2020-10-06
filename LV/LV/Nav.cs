using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LV
{
    public static class Nav
    {
        public static INavigation Navigation { get; set; }
        public static async Task Push(Page page)
        {
            await Navigation.PushAsync(page);
        }

        public static async Task Pop()
        {
            var page = await Navigation.PopAsync();

            (page as LVPage).Cleanup();
        }
    }
}
