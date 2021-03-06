﻿using System;
using MiningManager.ViewModel.ControllerInterfaces;

namespace MiningManager.ViewModel
{
    public class ContainerViewModel : BaseViewModel
    {
        protected IContainerController ContainerController => (IContainerController)Controller;

        public ContainerViewModel(IController controller) : base(controller)
        {
            Controller.Messenger.Register(Messengers.MessageTypes.MSG_COMMAND_MENU_FINDERMGR, GetFinderMgr);
        }



        public BaseViewModel CurrentViewModel
        {
            get { return GetValue(() => CurrentViewModel); }
            set { SetValue(() => CurrentViewModel, value); }
        }

        private void GetFinderMgr()
        {
            CurrentViewModel = ContainerController.ConstructFinderMgrViewModel();
        }
    }
}
