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
    public partial class GerenciamentoFamilia : ContentPage
    {
        public GerenciamentoFamilia()
        {
            InitializeComponent();
        }
        private async void btnadicionarmembro(object sender, EventArgs e)
        {
            string result = await DisplayPromptAsync("Novo Membro", "Digite o nome do membro que deseja adicionar");

        }
        private async void btnexcluirmembro(object sender, EventArgs e)
        {
            string result = await DisplayPromptAsync("Excluir Membro", "Digite o nome do membro que deseja excluir");

        }
        private async void btnlink(object sender, EventArgs e)
        {
            await DisplayAlert("Link da familia", "Alcantara/12345", "fechar");
        }
    }
}