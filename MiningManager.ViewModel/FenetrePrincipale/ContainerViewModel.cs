using MiningManager.ViewModel.ControllerInterfaces;

namespace MiningManager.ViewModel
{
    public class ContainerViewModel : BaseViewModel
    {
        protected IContainerController ContainerController => (IContainerController)Controller;

        public ContainerViewModel(IController controller) : base(controller)
        {
        }

        public BaseViewModel CurrentViewModel
        {
            get { return GetValue(() => CurrentViewModel); }
            set { SetValue(() => CurrentViewModel, value); }
        }
    }
}
