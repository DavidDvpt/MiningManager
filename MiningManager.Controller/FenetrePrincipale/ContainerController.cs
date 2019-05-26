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
            CommunRepository<Finder> ifr = new CommunRepository<Finder>();

            IEntityMgrController<FinderEditViewModel, FinderEditViewData, Finder, FinderListItemViewData> itemManagerController =
                new ItemManagerController<FinderEditViewModel, FinderEditViewData, Finder, FinderListItemViewData>(ifr);

            return new FinderMgrViewModel(itemManagerController);
        }

        public ExcavatorMgrViewModel ConstructExcavatorMgrViewModel()
        {
            CommunRepository<Excavator> ifr = new CommunRepository<Excavator>();

            IEntityMgrController<ExcavatorEditViewModel, ExcavatorEditViewData, Excavator, ExcavatorListItemViewData> itemManagerController =
                new ItemManagerController<ExcavatorEditViewModel, ExcavatorEditViewData, Excavator, ExcavatorListItemViewData>(ifr);

            return new ExcavatorMgrViewModel(itemManagerController);
        }

        public RefinerMgrViewModel ConstructRefinerMgrViewModel()
        {
            CommunRepository<Refiner> ifr = new CommunRepository<Refiner>();

            IEntityMgrController<RefinerEditViewModel, RefinerEditViewData, Refiner, RefinerListItemViewData> itemManagerController =
                new ItemManagerController<RefinerEditViewModel, RefinerEditViewData, Refiner, RefinerListItemViewData>(ifr);

            return new RefinerMgrViewModel(itemManagerController);
        }

        public FinderAmplifierMgrViewModel ConstructFinderAmplifierMgrViewModel()
        {
            CommunRepository<FinderAmplifier> ifr = new CommunRepository<FinderAmplifier>();

            IEntityMgrController<FinderAmplifierEditViewModel, FinderAmplifierEditViewData, FinderAmplifier, FinderAmplifierListItemViewData> itemManagerController =
                new ItemManagerController<FinderAmplifierEditViewModel, FinderAmplifierEditViewData, FinderAmplifier, FinderAmplifierListItemViewData>(ifr);

            return new FinderAmplifierMgrViewModel(itemManagerController);
        }

        public ModeleMgrViewModel ConstructModeleMgrViewModel()
        {
            CommunRepository<Modele> ifr = new CommunRepository<Modele>();

            IEntityMgrController<ModeleEditViewModel, ModeleEditViewData, Modele, ModeleListItemViewData> itemManagerController =
                new ItemManagerController<ModeleEditViewModel, ModeleEditViewData, Modele, ModeleListItemViewData>(ifr);

            return new ModeleMgrViewModel(itemManagerController);
        }
    }
}
