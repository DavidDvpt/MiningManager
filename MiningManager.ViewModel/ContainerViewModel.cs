﻿using MiningManager.Messengers;
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
            InitMenuLinks();
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
            ContainerController.Messenger.Register(Messengers.MessageTypes.MSG_COMMAND_MENU_GENERALMANAGER, new Action<Message>(ShowItemManager));
        }

        #endregion

        #region Propriétés bindables

        public BaseViewModel CurrentViewModel
        {
            get { return GetValue(() => CurrentViewModel); }
            set { SetValue(() => CurrentViewModel, value); }
        }

        #endregion

        private void ShowItemManager(Message message)
        {
            switch(message.Payload.ToString())
            {
                case "finder":
                default:
                    CurrentViewModel = ContainerController.GetFinderManagerViewModel(message.Payload.ToString());
                    break;
            }
        }
    }
}
