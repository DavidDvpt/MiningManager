namespace MiningManager.ViewModel.ControllerInterfaces
{
    public interface IContainerController : IController
    {
        void Start();

        BaseViewModel GetFinderManagerViewModel(string v);
    }
}
