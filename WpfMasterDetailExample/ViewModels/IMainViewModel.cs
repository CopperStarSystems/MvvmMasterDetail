using System.Collections.ObjectModel;

namespace WpfMasterDetailExample.ViewModels
{
    public interface IMainViewModel
    {
        ObservableCollection<IEventViewModel> ActiveEvents { get; }

        IEventViewModel SelectedEvent { get; set; }
    }
}