﻿using MiningManager.View;
using MiningManager.ViewModel.ControllerInterfaces;

namespace MiningManager.ViewModel
{
    public class StatusViewModel : BaseViewModel
    {
        public StatusViewModel(IController controller)
            : base(controller)
        {
        }

        public StatusViewModel(IController controller, IView view)
            : base(controller, view)
        {
        }
    }
}