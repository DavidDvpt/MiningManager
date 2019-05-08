namespace MiningManager.ViewModel.ControllerInterfaces
{
    public interface IContainerController : IController
    {
        void Start();

        MenuViewModel ShowViewMenu();

        StatusViewModel ShowViewStatus();

        //FinderMgrViewModel ShowFinderMgrViewModel();
    }
}
