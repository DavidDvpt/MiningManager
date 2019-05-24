using MiningManager.Model;

namespace MiningManager.ViewModel.ControllerInterfaces
{
    public interface IContainerController : IController
    {
        void Start();
        FinderMgrViewModel ConstructFinderMgrViewModel();

        ExcavatorMgrViewModel ConstructExcavatorMgrViewModel();

        RefinerMgrViewModel ConstructRefinerMgrViewModel();

    }
}
