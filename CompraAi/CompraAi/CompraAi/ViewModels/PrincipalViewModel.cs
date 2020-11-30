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
    public class PrincipalViewModel : ViewModelBase
    {
        private ObservableCollection<Item> _itens;
        public ObservableCollection<Item> Itens
        {
            get { return _itens; }
            set { SetProperty(ref _itens, value); }
        }

        public PrincipalViewModel(INavigationService navigationService, IPageDialogService pageDialogService)
            : base(navigationService, pageDialogService)
        {
            Title = "Principal";
            _itens = new ObservableCollection<Item>();
        }


        #region Commands
        public DelegateCommand<Item> ExcluirItemCommand => new DelegateCommand<Item>(async (item) => await ExcluirItemAsync(item));
        public DelegateCommand<Item> ComprarItemCommand => new DelegateCommand<Item>(async (item) => await ComprarItemAsync(item));

        
        #endregion

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            CarregarItens();
        }

        private void CarregarItens()
        {
            var itens = new List<Item>()
            {
                new Item() {ItemId = Guid.NewGuid(), Descricao = "Arroz", CriadoEm = DateTime.Now },
                new Item() {ItemId = Guid.NewGuid(), Descricao = "Feijão" , CriadoEm = DateTime.Now},
                new Item() {ItemId = Guid.NewGuid(), Descricao = "Macarrão", CriadoEm = DateTime.Now },
                new Item() {ItemId = Guid.NewGuid(), Descricao = "Farinha", CriadoEm = DateTime.Now },
                new Item() {ItemId = Guid.NewGuid(), Descricao = "Papel Toalha", CriadoEm = DateTime.Now },
                new Item() {ItemId = Guid.NewGuid(), Descricao = "Detergente" , CriadoEm = DateTime.Now},
                new Item() {ItemId = Guid.NewGuid(), Descricao = "Esponja de Aço", CriadoEm = DateTime.Now },
                new Item() {ItemId = Guid.NewGuid(), Descricao = "Papel Higiênico", CriadoEm = DateTime.Now }
            };

            itens.ForEach(i => Itens.Add(i));
        }

        private async Task ExcluirItemAsync(Item item)
        {
            bool resposta = await PageDialogService.DisplayAlertAsync("Exclusão item", "Deseja realmente excluir " + item.Descricao, "Sim", "Não");

            if (resposta)
                await PageDialogService.DisplayAlertAsync("Exclusão item", $"Item '{item.Descricao}' excluido com sucesso!", "OK");
            else
                await PageDialogService.DisplayAlertAsync("Exclusão item", $"Erro ao excluír item '{item.Descricao}'.", "OK");
        }

        private async Task ComprarItemAsync(Item item)
        {
            await PageDialogService.DisplayAlertAsync("Compra item", $"Compra do item '{item.Descricao}' confirmada com sucesso.", "OK");
        }

        public DelegateCommand BotaomaisCommand => new DelegateCommand(async () => await ExecuteBotaomaisAsync());

        private async Task ExecuteBotaomaisAsync()
        {
            await NavigationService.NavigateAsync($"{nameof(cadastraritem)}");

            
        }

        


    }
}
