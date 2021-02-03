using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GoStyle
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListPromo : ContentPage
    {
        public ListPromo(string dateDuJour)
        {
            InitializeComponent();

            LbldateDuJour.Text = dateDuJour;
        }

        private async void OnClickPreviousPage(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private async void OnClickQRCode(object sender, EventArgs e)
        {
            //await Navigation.PushAsync(new SecondPage());
            await Navigation.PushAsync(new Page3());
        }
    }
}