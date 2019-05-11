using System;
using MiningManager.ViewModel.ControllerInterfaces;

namespace MiningManager.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        protected IMainController MainController => (IMainController)Controller;

        public MainViewModel(IController controller) : base(controller)
        {
            InitViewModel();
        }

        private void InitViewModel()
        {
            CurrentMenuViewModel = MainController.GetMenuViewModel();
            CurrentContainerViewModel = MainController.GetContainerViewModel();
            CurrentStatusViewModel = MainController.GetStatusViewModel();
        }

        public MenuViewModel CurrentMenuViewModel
        {
            get { return GetValue(() => CurrentMenuViewModel); }
            set { SetValue(() => CurrentMenuViewModel, value); }
        }

        public ContainerViewModel CurrentContainerViewModel
        {
            get { return GetValue(() => CurrentContainerViewModel); }
            set { SetValue(() => CurrentContainerViewModel, value); }
        }

        public StatusViewModel CurrentStatusViewModel
        {
            get { return GetValue(() => CurrentStatusViewModel); }
            set { SetValue(() => CurrentStatusViewModel, value); }
        }
    }
}
