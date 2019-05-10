using MiningManager.ViewModel.ControllerInterfaces;
using System;

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
            ContainerController.Messenger.Register<string>(Messengers.MessageTypes.MSG_COMMAND_MENU_GENERALMANAGER, new Action<string>(x => ShowGeneralManager(x)));
        }

        #endregion

        #region Propriétés bindables

        public BaseViewModel CurrentViewModel
        {
            get { return GetValue(() => CurrentViewModel); }
            set { SetValue(() => CurrentViewModel, value); }
        }

        #endregion

        private void ShowGeneralManager(string managerToUse)
        {
            switch (managerToUse)
            {
         
                case "finderAmplifier":
                    CurrentViewModel = ContainerController.GetFinderAmplifierMgrViewModel();
                    break;
                case "excavator":
                    CurrentViewModel = ContainerController.GetExcavatorMgrViewModel();
                    break;
                case "refiner":
                    CurrentViewModel = ContainerController.GetRefinerMgrViewModel();
                    break;
                case "finder":
                default:
                    CurrentViewModel = ContainerController.GetGeneralFinderViewModel();      
                    break;
            }
        }
    }
}
