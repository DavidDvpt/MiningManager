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

            IEntityMgrController<FinderEditViewModel, FinderEditViewData, Finder, FinderListItemViewData> itemManagerController =
                new ItemManagerController<FinderEditViewModel, FinderEditViewData, Finder, FinderListItemViewData>(ifr);

            return new FinderMgrViewModel(itemManagerController);
        }

        public ExcavatorMgrViewModel ConstructExcavatorMgrViewModel()
        {
            InWorldRepository<Excavator> ifr = new InWorldRepository<Excavator>();

            IEntityMgrController<ExcavatorEditViewModel, ExcavatorEditViewData, Excavator, ExcavatorListItemViewData> itemManagerController =
                new ItemManagerController<ExcavatorEditViewModel, ExcavatorEditViewData, Excavator, ExcavatorListItemViewData>(ifr);

            return new ExcavatorMgrViewModel(itemManagerController);
        }

        public RefinerMgrViewModel ConstructRefinerMgrViewModel()
        {
            InWorldRepository<Refiner> ifr = new InWorldRepository<Refiner>();

            IEntityMgrController<RefinerEditViewModel, RefinerEditViewData, Refiner, RefinerListItemViewData> itemManagerController =
                new ItemManagerController<RefinerEditViewModel, RefinerEditViewData, Refiner, RefinerListItemViewData>(ifr);

            return new RefinerMgrViewModel(itemManagerController);
        }

        public FinderAmplifierMgrViewModel ConstructFinderAmplifierMgrViewModel()
        {
            InWorldRepository<FinderAmplifier> ifr = new InWorldRepository<FinderAmplifier>();

            IEntityMgrController<FinderAmplifierEditViewModel, FinderAmplifierEditViewData, FinderAmplifier, FinderAmplifierListItemViewData> itemManagerController =
                new ItemManagerController<FinderAmplifierEditViewModel, FinderAmplifierEditViewData, FinderAmplifier, FinderAmplifierListItemViewData>(ifr);

            return new FinderAmplifierMgrViewModel(itemManagerController);
        }
    }
}
