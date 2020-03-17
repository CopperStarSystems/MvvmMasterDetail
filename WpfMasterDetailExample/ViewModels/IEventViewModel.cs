using System.Collections.ObjectModel;

namespace WpfMasterDetailExample.ViewModels
{
    public interface IEventViewModel
    {
        ObservableCollection<IRespondingUnitViewModel> RespondingUnits { get; }
    }
}