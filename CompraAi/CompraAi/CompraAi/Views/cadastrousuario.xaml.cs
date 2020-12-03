using Xamarin.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompraAi.Servicos;
using CompraAi.Dominio;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using CompraAi.ViewModels;

namespace CompraAi.Views
{
    public partial class cadastrousuario : ContentPage
    {
        public cadastrousuario()
        {
            InitializeComponent();
        }
        private async void Btncad_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Cadastro", "Você foi cadastrado com sucesso", "fechar");
        }
        
    }
}
