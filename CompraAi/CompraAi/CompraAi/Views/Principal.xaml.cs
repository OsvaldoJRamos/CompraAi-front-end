using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;

namespace CompraAi.Views
{



    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Principal : ContentPage
    {
        public string userId;
        public MainPage main;

        public Principal(string Id)
        {
            InitializeComponent();
            
            userId = Id;
            main = new MainPage();

        }
        public Principal()
        {
            InitializeComponent();
                
            userId = "";
        }

        private async void btnfoto(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new mostrarArroz());
        }

    }

}