using MiningManager.View;
using MiningManager.ViewModel.ControllerInterfaces;

namespace MiningManager.ViewModel
{
    public class ContainerViewModel : BaseViewModel
    {
        public ContainerViewModel(IController controller) : base(controller)
        {
        }

        public ContainerViewModel(IController controller, IView view) : base(controller, view)
        {
        }
    }
}
