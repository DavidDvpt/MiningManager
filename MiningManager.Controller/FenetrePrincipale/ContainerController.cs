using MiningManager.Model;
using MiningManager.Repository;
using MiningManager.ViewModel;
using MiningManager.ViewModel.ControllerInterfaces;
using MiningManager.ViewModel.ViewData;

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

        public ExcavatorMgrViewModel ConstructExcavatorMgrViewModel()
        {
            InWorldRepository<Excavator> ifr = new InWorldRepository<Excavator>();

            IItemManagerController<ExcavatorEditViewModel, ExcavatorEditViewData, Excavator, ExcavatorItemListViewData> itemManagerController =
                new ItemManagerController<ExcavatorEditViewModel, ExcavatorEditViewData, Excavator, ExcavatorItemListViewData>(ifr);

            return new ExcavatorMgrViewModel(itemManagerController);
        }

        public RefinerMgrViewModel ConstructRefinerMgrViewModel()
        {
            InWorldRepository<Refiner> ifr = new InWorldRepository<Refiner>();

            IItemManagerController<RefinerEditViewModel, RefinerEditViewData, Refiner, RefinerItemListViewData> itemManagerController =
                new ItemManagerController<RefinerEditViewModel, RefinerEditViewData, Refiner, RefinerItemListViewData>(ifr);

            return new RefinerMgrViewModel(itemManagerController);
        }
    }
}
