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

        #region Commands

        public RelayCommand FinderMgr => new RelayCommand(x => { Controller.Messenger.NotifyColleagues(MessageTypes.MSG_COMMAND_MENU_FINDERMGR); });
        public RelayCommand ExcavatorMgr => new RelayCommand(x => { Controller.Messenger.NotifyColleagues(MessageTypes.MSG_COMMAND_MENU_EXCAVATORMGR); });
        public RelayCommand RefinerMgr => new RelayCommand(x => { Controller.Messenger.NotifyColleagues(MessageTypes.MSG_COMMAND_MENU_REFINERMGR); });
        public RelayCommand FinderAmplifierMgr => new RelayCommand(x => { Controller.Messenger.NotifyColleagues(MessageTypes.MSG_COMMAND_MENU_FINDERAMPLIFIERMGR); });
        public RelayCommand ModeleMgr => new RelayCommand(x => { Controller.Messenger.NotifyColleagues(MessageTypes.MSG_COMMAND_MENU_MODELEMGR); });

        #endregion

        #region Execute Command

        #endregion
    }
}
