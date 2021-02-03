using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GoStyle
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnClickListPromo(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.Text = "PROMO";

            var dateDuJour = DateTime.Now.ToString("F");

            await Navigation.PushAsync(new ListPromo(dateDuJour));
        }

        private void OnPressListPromo(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            BtnListPromo.BackgroundColor = Color.LightBlue;
        }

        private void OnReleaseListPromo(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            BtnListPromo.BackgroundColor = Color.FromHex("#2196F3");
        }
    }
}
