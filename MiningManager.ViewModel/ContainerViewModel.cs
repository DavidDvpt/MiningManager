using MiningManager.ViewModel.ControllerInterfaces;

namespace MiningManager.ViewModel
{
    public class ContainerViewModel : BaseViewModel
    {
        #region Champs

        private IContainerController ContainerController => (IContainerController)Controller;

        #endregion

        #region Constructeurs

        public ContainerViewModel(IController controller) : base(controller)
        {
        }

        public ContainerViewModel(IController controller, IView view) : base(controller, view)
        {
            InitMenuLinks();
        }

        /// <summary>
        /// Initialisation des liens du menu (messages)
        /// </summary>
        private void InitMenuLinks()
        {
            ContainerController.Messenger.Register(Messengers.MessageTypes.MSG_COMMAND_MENU_FINDERMGR, ShowFinderManager);
            ContainerController.Messenger.Register(Messengers.MessageTypes.MSG_COMMAND_MENU_FINDERAMPLIFIERMGR, ShowFinderAmplifierManager);
            ContainerController.Messenger.Register(Messengers.MessageTypes.MSG_COMMAND_MENU_EXCAVATORMGR, ShowExcavatorManager);
            ContainerController.Messenger.Register(Messengers.MessageTypes.MSG_COMMAND_MENU_REFINERMGR, ShowRefinerManager);
        }

        #endregion

        #region Propriétés bindables

        public BaseViewModel CurrentViewModel
        {
            get { return GetValue(() => CurrentViewModel); }
            set { SetValue(() => CurrentViewModel, value); }
        }

        #endregion

        private void ShowFinderManager()
        {
            CurrentViewModel = ContainerController.GetFinderMgrViewModel();
        }

        private void ShowExcavatorManager()
        {
            CurrentViewModel = ContainerController.GetExcavatorMgrViewModel();
        }

        private void ShowRefinerManager()
        {
            CurrentViewModel = ContainerController.GetRefinerMgrViewModel();
        }

        private void ShowFinderAmplifierManager()
        {
            CurrentViewModel = ContainerController.GetFinderAmplifierMgrViewModel();
        }
    }
}
