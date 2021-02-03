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
    public partial class Page3 : ContentPage
    {
        private Page3 viewModel;
        public Page3()
        {
            InitializeComponent();
            BindingContext = viewModel = new Page3();
            RegisterMesssages();
        }

        private void RegisterMesssages()
        {
            MessagingCenter.Subscribe<Page3>(this, "NoScanResultToClear", (m) =>
            {
                if (m != null)
                {
                    DisplayAlert("Warning !", "No scan result to clear.", "OK");
                }
            });

            MessagingCenter.Subscribe<Page3>(this, "NoScanResultToShare", (m) =>
            {
                if (m != null)
                {
                    DisplayAlert("Warning !", "No scan result to share.", "OK");
                }
            });
        }
    }
}