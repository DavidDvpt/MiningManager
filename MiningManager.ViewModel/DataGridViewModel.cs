using MiningManager.ViewModel.ControllerInterfaces;

namespace MiningManager.ViewModel
{
    public class DataGridViewModel : BaseViewModel
    {
        public DataGridViewModel(IController controller) : base(controller)
        {
        }

        public DataGridViewModel(IController controller, IView view) : base(controller, view)
        {
        }
    }
}
