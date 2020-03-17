using Autofac;
using WpfMasterDetailExample.ViewModels;

namespace WpfMasterDetailExample.Factory
{
    public class ViewModelFactory : IViewModelFactory
    {
        private readonly ILifetimeScope scope;

        public ViewModelFactory(ILifetimeScope scope)
        {
            this.scope = scope;
        }

        public T Create<T>() where T : IViewModel
        {
            return scope.Resolve<T>();
        }
    }
}