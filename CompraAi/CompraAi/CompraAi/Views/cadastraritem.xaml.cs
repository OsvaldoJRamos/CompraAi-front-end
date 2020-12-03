using System;
using Xamarin.Forms;

namespace CompraAi.Views
{
    public partial class cadastraritem : ContentPage
    {
        public cadastraritem()
        {
            InitializeComponent();
        }

        private async void btncaditem_clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Cadastro de item", "Você cadastrou o item com sucesso", "fechar");
        }
        private async void btngaleria_clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Cadastro de Foto", "Foto cadastrada com sucesso", "fechar");
        }
    }
}
