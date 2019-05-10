using MiningManager.ViewModel.ControllerInterfaces;

namespace MiningManager.ViewModel
{
    public class ItemManagerViewModel : BaseViewModel
    {
        public ItemManagerViewModel(IController controller) : base(controller)
        {
        }

        public ItemManagerViewModel(IController controller, string parameter) : base(controller)
        {

        }
        public ItemManagerViewModel(IController controller, IView view) : base(controller, view)
        {
        }
    }
}
