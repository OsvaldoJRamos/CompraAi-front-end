using Prism;
using Prism.Ioc;
using CompraAi.ViewModels;
using CompraAi.Views;
using Xamarin.Essentials.Interfaces;
using Xamarin.Essentials.Implementation;
using Xamarin.Forms;
using System;
using System.Threading.Tasks;

namespace CompraAi
{
    public partial class App
    {
        public App(IPlatformInitializer initializer)
            : base(initializer)
        {
        }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync("NavigationPage/MainPage");
        }
        public static Action HideLoginView
        {
            get
            {
                return new Action(() => App.Current.MainPage.Navigation.PopModalAsync());
            }
        }
        public async static Task NavigateToProfile(string message)
        {
            await App.Current.MainPage.Navigation.PushAsync(new Profile(message));
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IAppInfo, AppInfoImplementation>();

            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<Autenticacao>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
            containerRegistry.RegisterForNavigation<Principal, PrincipalViewModel>();
            containerRegistry.RegisterForNavigation<GerenciamentoFamilia, GerenciamentoFamiliaViewModel>();
            //containerRegistry.RegisterForNavigation<LoginFacebook>();
            //containerRegistry.RegisterForNavigation<Profile>();
            containerRegistry.RegisterForNavigation<cadastraritem, cadastraritemViewModel>();
            containerRegistry.RegisterForNavigation<pesquisaritem, pesquisaritemViewModel>();
        }
    }
}
