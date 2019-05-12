using MiningManager.Model;
using MiningManager.Repository;
using MiningManager.ViewModel;
using MiningManager.ViewModel.ControllerInterfaces;
using System.Collections.Generic;
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
            foreach (var item in ((IFinderRepository)_repository).GetAll().ToList())
            {
                filvd = new FinderItemListViewData();
                filvd.GetPropertiesValues(item);
            }

        }
    }
}
