using MiningManager.Model;
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

        public GeneralManagerViewModel<FinderEditViewModel, FinderEditViewData, Finder, FinderItemListViewData, ManagerGenericItemListViewData<FinderItemListViewData>> ConstructFinderMgrViewModel()
        {
            CommunRepository<Finder> ifr = new CommunRepository<Finder>();

            ItemManagerController<FinderEditViewModel, FinderEditViewData, Finder, FinderItemListViewData, ManagerGenericItemListViewData<FinderItemListViewData>> itemManagerController =
                new ItemManagerController<FinderEditViewModel, FinderEditViewData, Finder, FinderItemListViewData, ManagerGenericItemListViewData<FinderItemListViewData>>(ifr);

            return new GeneralManagerViewModel<FinderEditViewModel, FinderEditViewData, Finder, FinderItemListViewData, ManagerGenericItemListViewData<FinderItemListViewData>>(itemManagerController);
        }
    }
}
