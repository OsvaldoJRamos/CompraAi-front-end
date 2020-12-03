using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CompraAi.ViewModels
{
    public class mostrarArrozViewModel : ViewModelBase
    {
        public mostrarArrozViewModel(INavigationService navigationService, IPageDialogService pageDialogService)
            : base(navigationService, pageDialogService)
        {
            Title = "Foto do Item";
        }
    }
}
