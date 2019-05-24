using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiningManager.ViewModel.ControllerInterfaces
{
    public interface IMainController
    {
        MenuViewModel GetMenuViewModel();
        ContainerViewModel GetContainerViewModel();
        StatusViewModel GetStatusViewModel();
    }
}
