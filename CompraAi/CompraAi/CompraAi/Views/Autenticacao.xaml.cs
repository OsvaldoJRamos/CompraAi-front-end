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
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Autenticacao : ContentPage
    {
        //public PrincipalViewModel viewModel;
        
        public Autenticacao()
        {
            InitializeComponent();
            //viewModel = new PrincipalViewModel(Navigation, PageDialogService);
            //BindingContext = viewModel;
        }

        private async void BtnLoginFacebook_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Login());

        }
        

       /* private async void BtnLogin_Clicked(object sender, EventArgs e)
        {
            UsuarioServico usuarioServico = new UsuarioServico();
            Usuario usuario = new Usuario();
            usuario.Nome = Nome.Text;
            usuario.Email = Email.Text;
            //var cadastroUsuario= await usuarioServico.CadastrarUsuarioAsync(usuario);         
            
            await Navigation.PushAsync(new MainPage("3fa85f64-5717-4562-b3fc-2c963f66afa6"));
        }*/

        private async void btncadastro(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new cadastrousuario());
        }

        
        private async void BtnLoginAnonimo_Clicked(object sender, EventArgs e)
        {
            //App.Current.MainPage = new NavigationPage(new MainPage());
            await Navigation.PopAsync();
        }
    }
}