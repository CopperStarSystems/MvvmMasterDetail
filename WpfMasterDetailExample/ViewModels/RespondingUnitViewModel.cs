using GalaSoft.MvvmLight;

namespace WpfMasterDetailExample.ViewModels
{
    public class RespondingUnitViewModel : ViewModelBase, IRespondingUnitViewModel
    {
        private string name;

        public string Name
        {
            get => name;
            set => name = value;
        }
    }
}