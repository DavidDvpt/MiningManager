using MiningManager.Messengers;
using MiningManager.ViewModel.ControllerInterfaces;

namespace MiningManager.ViewModel
{
    public class MenuViewModel : BaseViewModel
    {
        private IMenuController MenuController => (IMenuController)Controller;

        public MenuViewModel(IController controller)
            : base(controller)
        {
        }

        public MenuViewModel(IController controller, IView view)
            : base(controller, view)
        {
        }

        #region Commands

        public RelayCommand GeneralManager => new RelayCommand(x => { Controller.Messenger.NotifyColleagues(MessageTypes.MSG_COMMAND_MENU_GENERALMANAGER, x); } );

        #endregion

        #region Execute Command

        #endregion
    }
}
