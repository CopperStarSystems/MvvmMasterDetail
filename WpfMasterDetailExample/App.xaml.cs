using System.Windows;
using Autofac;
using WpfMasterDetailExample.Factory;
using WpfMasterDetailExample.ViewModels;

namespace WpfMasterDetailExample
{
    /// <summary>
    ///     Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            var builder = new ContainerBuilder();

            builder.RegisterType<MainViewModel>().As<IMainViewModel>();

            builder.RegisterType<ViewModelFactory>().As<IViewModelFactory>();
            builder.RegisterType<EventViewModel>().As<IEventViewModel>();
            builder.RegisterType<RespondingUnitViewModel>().As<IRespondingUnitViewModel>();
            builder.RegisterType<MainWindow>().AsSelf();

            var container = builder.Build();

            var mainView = container.Resolve<MainWindow>();
            var mainViewModel = container.Resolve<IMainViewModel>();
            mainView.DataContext = mainViewModel;
            mainView.Show();
        }
    }
}