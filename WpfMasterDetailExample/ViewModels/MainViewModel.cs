using System.Collections.ObjectModel;
using GalaSoft.MvvmLight;
using WpfMasterDetailExample.Factory;

namespace WpfMasterDetailExample.ViewModels
{
    public class MainViewModel : ViewModelBase, IMainViewModel
    {
        private readonly IViewModelFactory viewModelFactory;

        private IEventViewModel selectedEvent;

        public MainViewModel(IViewModelFactory viewModelFactory)
        {
            this.viewModelFactory = viewModelFactory;
            ActiveEvents = new ObservableCollection<IEventViewModel>();
            PopulateEvents();
        }

        public ObservableCollection<IEventViewModel> ActiveEvents { get; }

        public IEventViewModel SelectedEvent
        {
            get => selectedEvent;
            set
            {
                selectedEvent = value;
                RaisePropertyChanged(nameof(SelectedEvent));
            }
        }

        private void PopulateEvents()
        {
            var currentUnitIndex = 1;
            for (var index = 0; index < 5; index++)
            {
                var eventVm = viewModelFactory.Create<IEventViewModel>();
                eventVm.Name = $"Event {index + 1}";
                ActiveEvents.Add(eventVm);
                for (var unitIndex = 0; unitIndex < 3; unitIndex++)
                {
                    var respondingUnit = viewModelFactory.Create<IRespondingUnitViewModel>();
                    respondingUnit.Name = $"Unit {currentUnitIndex++}";
                    eventVm.RespondingUnits.Add(respondingUnit);
                }
            }
        }
    }
}