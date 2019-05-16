using MiningManager.Model;
using MiningManager.Repository;
using MiningManager.ViewModel.ControllerInterfaces;
using MiningManager.ViewModel;
using System.Collections.ObjectModel;
using System.Linq;

namespace MiningManager.Controller
{
    class ItemManagerController : BaseController, IItemManagerController, IFinderManagerController
    {
        public ItemManagerController()
        {

        }

        public ItemManagerController(BaseRepository repository)
        {
            _repository = repository;
        }

        public FinderEditViewModel ConstructFinderEditViewModel(int selectedFinderId)
        {
            return new FinderEditViewModel(this, selectedFinderId);
        }

        public BaseViewData ConstructFinderViewData(int selectedFinder)
        {
            Finder f = ((IFinderRepository)_repository).GetById(selectedFinder);
            FinderEditViewData fevd = new FinderEditViewData();
            fevd.ImportPropertiesValuesFromModel(f);

            return fevd;
        }

        public ObservableCollection<FinderItemListViewData> DataViewFinderList()
        {
            ObservableCollection<FinderItemListViewData> oc = new ObservableCollection<FinderItemListViewData>();
            FinderItemListViewData filvd;
            foreach (Finder item in ((IFinderRepository)_repository).GetAll().ToList())
            {
                filvd = new FinderItemListViewData();
                filvd.ImportPropertiesValuesFromModel(item);
                oc.Add(filvd);
            }

            return oc;
        }
    }
}
