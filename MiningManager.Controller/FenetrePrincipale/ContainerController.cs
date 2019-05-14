using MiningManager.Repository;
using MiningManager.ViewModel;
using MiningManager.ViewModel.ControllerInterfaces;

namespace MiningManager.Controller
{
    public class ContainerController : BaseController, IContainerController
    {


        public void Start()
        {
        }

        public FinderManagerViewModel ConstructFinderMgrViewModel()
        {
            IFinderRepository ifr = new FinderRepository();
            IFinderManagerController fmc = new ItemManagerController((BaseRepository)ifr);
            return new FinderManagerViewModel(fmc);
        }
    }
}
