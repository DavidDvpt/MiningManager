using MiningManager.Messengers;
using MiningManager.ViewModel.ControllerInterfaces;
using MiningManager.ViewModel.ViewData;

namespace MiningManager.ViewModel
{
    public abstract class ItemManagerViewModel : BaseViewModel
    {
        public ItemManagerViewModel(IController controller) : base(controller)
        {
        }

        public BaseViewModel CurrentViewModel
        {
            get { return GetValue(() => CurrentViewModel); }
            set { SetValue(() => CurrentViewModel, value); }
        }

        public BaseViewData SelectedItem
        {
            get { return GetValue(() => SelectedItem); }
            set { SetValue(() => SelectedItem, value); }
        }

        public void RefreshDataGridSource()
        {

        }

        public void RefreshDataGridSource(Message message)
        {

        }
    }
}
