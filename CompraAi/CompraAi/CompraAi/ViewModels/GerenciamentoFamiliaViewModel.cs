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
    public class GerenciamentoFamiliaViewModel : ViewModelBase
    {
        private ObservableCollection<Usuario> _integrantes;
        public ObservableCollection<Usuario> Integrantes
        {
            get { return _integrantes; }
            set { SetProperty(ref _integrantes, value); }
        }

        public Familia Familia { get; set; }
        public GerenciamentoFamiliaViewModel(INavigationService navigationService, IPageDialogService pageDialogService)
            : base(navigationService, pageDialogService)
        {
            Title = "Família";
            _integrantes = new ObservableCollection<Usuario>();
            Familia = new Familia() { FamiliaId = Guid.NewGuid(), Nome = "Alcântara", Codigo = "12345", CriadoEm = DateTime.Now};
            CarregarIntegrantes();
        }

        private void CarregarIntegrantes()
        {
            var integrantes = new List<Usuario>()
            {
                new Usuario(){UsuarioId = Guid.NewGuid(), Nome = "Lucas",Email = "lucashmalcantara@gmail.com", CriadoEm = DateTime.Now},
                new Usuario(){UsuarioId = Guid.NewGuid(), Nome = "Mika",Email = "lucashmalcantara@gmail.com", CriadoEm = DateTime.Now},
                new Usuario(){UsuarioId = Guid.NewGuid(), Nome = "Lucas",Email = "lucashmalcantara@gmail.com", CriadoEm = DateTime.Now}
            };

            integrantes.ForEach(i => Integrantes.Add(i));
        }
    }
}
