using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CompraAi.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Autenticacao : ContentPage
    {
        public Autenticacao()
        {
            InitializeComponent();
        }

        private async void BtnLoginFacebook_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Login());
        }

        private async void BtnLoginAnonimo_Clicked(object sender, EventArgs e)
        {
            //App.Current.MainPage = new NavigationPage(new MainPage());
            await Navigation.PopAsync();
        }
    }
}