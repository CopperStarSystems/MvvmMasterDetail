using System.Collections.ObjectModel;
using GalaSoft.MvvmLight;

namespace WpfMasterDetailExample.ViewModels
{
    public class EventViewModel : ViewModelBase, IEventViewModel
    {
        private string name;

        public EventViewModel()
        {
            RespondingUnits = new ObservableCollection<IRespondingUnitViewModel>();
        }

        public string Name
        {
            get => name;
            set
            {
                name = value;
                RaisePropertyChanged(nameof(Name));
            }
        }

        public ObservableCollection<IRespondingUnitViewModel> RespondingUnits { get; }
    }
}