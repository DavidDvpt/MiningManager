namespace MiningManager.ViewModel.ControllerInterfaces
{
    public interface IContainerController : IController
    {
        void Start();

        BaseViewModel GetGeneralFinderViewModel();
        BaseViewModel GetExcavatorMgrViewModel();
        BaseViewModel GetRefinerMgrViewModel();
        BaseViewModel GetFinderAmplifierMgrViewModel();
    }
}
