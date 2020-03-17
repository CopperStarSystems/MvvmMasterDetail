using System.Collections.ObjectModel;

namespace WpfMasterDetailExample.ViewModels
{
    public interface IEventViewModel : IViewModel
    {
        string Name { get; set; }
        ObservableCollection<IRespondingUnitViewModel> RespondingUnits { get; }
    }
}