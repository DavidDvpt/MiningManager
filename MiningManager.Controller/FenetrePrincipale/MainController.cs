using MiningManager.ViewModel;
using MiningManager.ViewModel.ControllerInterfaces;

namespace MiningManager.Controller
{
    public class MainController : BaseController, IMainController
    {
        public MenuViewModel GetMenuViewModel()
        {
            MenuController mc = new MenuController();

            return new MenuViewModel(mc);
        }

        public ContainerViewModel GetContainerViewModel()
        {
            ContainerController cc = new ContainerController();

            return new ContainerViewModel(cc);
        }

        public StatusViewModel GetStatusViewModel()
        {
            StatusController sc = new StatusController();

            return new StatusViewModel(sc);
        }
    }
}
