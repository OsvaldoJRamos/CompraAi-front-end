using CompraAi.Dominio;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompraAi.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private ObservableCollection<Item> _itens;
        public ObservableCollection<Item> Itens
        {
            get { return _itens; }
            set { SetProperty(ref _itens, value); }
        }

        public MainPageViewModel(INavigationService navigationService, IPageDialogService pageDialogService)
            : base(navigationService, pageDialogService)
        {
            Title = "Main Page";
            _itens = new ObservableCollection<Item>();
        }



        #region Commands
        public DelegateCommand<Item> ExcluirItemCommand => new DelegateCommand<Item>(async (item) => await ExcluirItemAsync(item));
        #endregion

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            CarregarItens();
        }

        private void CarregarItens()
        {
            var itens = new List<Item>()
            {
                new Item() {ItemId = "1", Descricao = "Teste...1" },
                new Item() {ItemId = "2", Descricao = "Teste...2" },
                new Item() {ItemId = "3", Descricao = "Teste...3" },
                new Item() {ItemId = "4", Descricao = "Teste...4" },
                new Item() {ItemId = "5", Descricao = "Teste...5" },
                new Item() {ItemId = "6", Descricao = "Teste...6" },
                new Item() {ItemId = "7", Descricao = "Teste...7" },
                new Item() {ItemId = "8", Descricao = "Teste...8" }
            };

            itens.ForEach(i => Itens.Add(i));
        }

        private async Task ExcluirItemAsync(Item item)
        {
            bool resposta = await PageDialogService.DisplayAlertAsync("Primeiro Xamarin", "Deseja realmente excluir " + item.Descricao, "Sim", "Não");

            if (resposta)
                await PageDialogService.DisplayAlertAsync("Primeiro Xamarin", $"Item '{item.Descricao}' excluido com sucesso!", "OK");
            else
                await PageDialogService.DisplayAlertAsync("Primeiro Xamarin", $"Erro ao excluír item '{item.Descricao}'.", "OK");
        }
    }
}
