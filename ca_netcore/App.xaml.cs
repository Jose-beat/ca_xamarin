using ca_netcore.Framework.DataSources;
using ca_netcore.UI.Orders.ViewModels;
using ca_netcore.UI.Orders.Views;
using Data.Orders;
using Prism;
using Prism.Ioc;
using Prism.Navigation;
using Prism.Unity;
using System;
using UseCases.Orders;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ca_netcore
{
    public partial class App : PrismApplication
    { 
        public App(IPlatformInitializer platformInitializer = null) : base(platformInitializer) { }

        protected override void RegisterTypes(IContainerRegistry containerRegistry) 
        {
            //Como primer paso vamos a registrar nuestra pagina y su view model (depende el modelo de vistas a usar)
            containerRegistry.RegisterForNavigation<OrdersListPage, OrdersListPageViewModel>();
            //Ahora vamos a inyectar nuestro repositorio, nuestra fuente de datos y a que interfaz aplicara o extiende y por ultimo nuestro caso de uso.s
            containerRegistry.Register<OrdersRepository>();
            containerRegistry.Register<IOrderSource, InMemoryOrdersSource>();
            containerRegistry.Register<GetCurrentUsersOrder>();
            
        }

        protected override void OnInitialized() 
        {
            InitializeComponent();
            NavigationService.NavigateAsync("OrdersListPage");
        }

    //    public App()
    //    {
    //        InitializeComponent();

    //        MainPage = new MainPage();
    //    }

    //    protected override void OnStart()
    //    {
    //    }

    //    protected override void OnSleep()
    //    {
    //    }

    //    protected override void OnResume()
    //    {
    //    }
    }
}
