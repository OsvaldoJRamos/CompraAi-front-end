using CompraAi.Dominio;
using CompraAi.Views;
using Prism.Commands;
using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace CompraAi.ViewModels
{
    public class Autenticacaoviewmodel : ViewModelBase
    {
        public Autenticacaoviewmodel(INavigationService navigationService, IPageDialogService pageDialogService)
            : base(navigationService, pageDialogService)
        {
            Title = "Cadastrar item";
        }


        public DelegateCommand btncadastro => new DelegateCommand(async () => await ExecutebtncadastroAsync());

        private async Task ExecutebtncadastroAsync()
        {
            await NavigationService.NavigateAsync($"{nameof(cadastrousuario)}");


        }
    }
}
