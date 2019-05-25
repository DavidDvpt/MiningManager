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

            IEntityMgrController<FinderEditViewModel, FinderEditViewData, Finder, FinderItemListViewData> itemManagerController =
                new EntityMgrController<FinderEditViewModel, FinderEditViewData, Finder, FinderItemListViewData>(ifr);

            return new FinderMgrViewModel(itemManagerController);
        }

        public ExcavatorMgrViewModel ConstructExcavatorMgrViewModel()
        {
            InWorldRepository<Excavator> ifr = new InWorldRepository<Excavator>();

            IEntityMgrController<ExcavatorEditViewModel, ExcavatorEditViewData, Excavator, ExcavatorItemListViewData> itemManagerController =
                new EntityMgrController<ExcavatorEditViewModel, ExcavatorEditViewData, Excavator, ExcavatorItemListViewData>(ifr);

            return new ExcavatorMgrViewModel(itemManagerController);
        }

        public RefinerMgrViewModel ConstructRefinerMgrViewModel()
        {
            InWorldRepository<Refiner> ifr = new InWorldRepository<Refiner>();

            IEntityMgrController<RefinerEditViewModel, RefinerEditViewData, Refiner, RefinerItemListViewData> itemManagerController =
                new EntityMgrController<RefinerEditViewModel, RefinerEditViewData, Refiner, RefinerItemListViewData>(ifr);

            return new RefinerMgrViewModel(itemManagerController);
        }

        public FinderAmplifierMgrViewModel ConstructFinderAmplifierMgrViewModel()
        {
            InWorldRepository<FinderAmplifier> ifr = new InWorldRepository<FinderAmplifier>();

            IEntityMgrController<FinderAmplifierEditViewModel, FinderAmplifierEditViewData, FinderAmplifier, FinderAmplifierItemListViewData> itemManagerController =
                new EntityMgrController<FinderAmplifierEditViewModel, FinderAmplifierEditViewData, FinderAmplifier, FinderAmplifierItemListViewData>(ifr);

            return new FinderAmplifierMgrViewModel(itemManagerController);
        }
    }
}
