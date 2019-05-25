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

            IInWorldManagerController<FinderEditViewModel, FinderEditViewData, Finder, FinderItemListViewData> itemManagerController =
                new InWorldManagerController<FinderEditViewModel, FinderEditViewData, Finder, FinderItemListViewData>(ifr);

            return new FinderMgrViewModel(itemManagerController);
        }

        public ExcavatorMgrViewModel ConstructExcavatorMgrViewModel()
        {
            InWorldRepository<Excavator> ifr = new InWorldRepository<Excavator>();

            IInWorldManagerController<ExcavatorEditViewModel, ExcavatorEditViewData, Excavator, ExcavatorItemListViewData> itemManagerController =
                new InWorldManagerController<ExcavatorEditViewModel, ExcavatorEditViewData, Excavator, ExcavatorItemListViewData>(ifr);

            return new ExcavatorMgrViewModel(itemManagerController);
        }

        public RefinerMgrViewModel ConstructRefinerMgrViewModel()
        {
            InWorldRepository<Refiner> ifr = new InWorldRepository<Refiner>();

            IInWorldManagerController<RefinerEditViewModel, RefinerEditViewData, Refiner, RefinerItemListViewData> itemManagerController =
                new InWorldManagerController<RefinerEditViewModel, RefinerEditViewData, Refiner, RefinerItemListViewData>(ifr);

            return new RefinerMgrViewModel(itemManagerController);
        }

        public FinderAmplifierMgrViewModel ConstructFinderAmplifierMgrViewModel()
        {
            InWorldRepository<FinderAmplifier> ifr = new InWorldRepository<FinderAmplifier>();

            IInWorldManagerController<FinderAmplifierEditViewModel, FinderAmplifierEditViewData, FinderAmplifier, FinderAmplifierItemListViewData> itemManagerController =
                new InWorldManagerController<FinderAmplifierEditViewModel, FinderAmplifierEditViewData, FinderAmplifier, FinderAmplifierItemListViewData>(ifr);

            return new FinderAmplifierMgrViewModel(itemManagerController);
        }
    }
}
