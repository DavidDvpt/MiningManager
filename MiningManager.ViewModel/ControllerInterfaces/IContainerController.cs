using MiningManager.Model;

namespace MiningManager.ViewModel.ControllerInterfaces
{
    public interface IContainerController : IController
    {
        void Start();
        FinderManagerViewModel ConstructFinderMgrViewModel();
    }
}
