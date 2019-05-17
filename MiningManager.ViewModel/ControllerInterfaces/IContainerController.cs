using MiningManager.Model;

namespace MiningManager.ViewModel.ControllerInterfaces
{
    public interface IContainerController : IController
    {
        void Start();
        GeneralManagerViewModel<FinderEditViewModel, FinderEditViewData, Finder, FinderItemListViewData, ManagerGenericItemListViewData<FinderItemListViewData>> ConstructFinderMgrViewModel();
    }
}
