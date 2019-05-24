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

        public FinderMgrViewModel ConstructFinderMgrViewModel()
        {
            InWorldRepository<Finder> ifr = new InWorldRepository<Finder>();

            IItemManagerController<FinderEditViewModel, FinderEditViewData, Finder, FinderItemListViewData> itemManagerController =
                new ItemManagerController<FinderEditViewModel, FinderEditViewData, Finder, FinderItemListViewData>(ifr);

            return new FinderMgrViewModel(itemManagerController);
        }
    }
}
