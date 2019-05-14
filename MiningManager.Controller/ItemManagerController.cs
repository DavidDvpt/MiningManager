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
