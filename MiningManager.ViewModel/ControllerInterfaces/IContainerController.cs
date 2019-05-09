namespace MiningManager.ViewModel.ControllerInterfaces
{
    public interface IContainerController : IController
    {
        void Start();

        BaseViewModel GetFinderMgrViewModel();
        BaseViewModel GetExcavatorMgrViewModel();
        BaseViewModel GetRefinerMgrViewModel();
        BaseViewModel GetFinderAmplifierMgrViewModel();
    }
}
