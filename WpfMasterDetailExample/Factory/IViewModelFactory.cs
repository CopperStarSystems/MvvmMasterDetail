using System.Runtime.InteropServices.ComTypes;
using GalaSoft.MvvmLight;
using WpfMasterDetailExample.ViewModels;

namespace WpfMasterDetailExample.Factory
{
    public interface IViewModelFactory
    {
        T Create<T>() where T : IViewModel;
    }
}