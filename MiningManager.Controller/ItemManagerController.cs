using MiningManager.Model;
using MiningManager.Repository;
using MiningManager.ViewModel.ControllerInterfaces;
using MiningManager.ViewModel;
using System.Collections.ObjectModel;
using System.Linq;
using MiningManager.Messengers;

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

        public FinderEditViewModel ConstructFinderEditViewModel(int selectedFinderId = 0)
        {
            return new FinderEditViewModel(this, selectedFinderId);
        }

        /// <summary>
        /// crée un viewdata à partir de l'id de l'item selectionné
        /// </summary>
        /// <param name="selectedFinder"></param>
        /// <returns></returns>
        public BaseViewData ConstructFinderViewData(int selectedFinder = 0)
        {
            FinderEditViewData fevd = new FinderEditViewData();
            if (selectedFinder != 0)
            {
                Finder f = ((IFinderRepository)_repository).GetById(selectedFinder);
                fevd.ImportPropertiesValuesFromModel(f);
            }

            return fevd;
        }

        /// <summary>
        /// Cree une liste observable des item
        /// </summary>
        /// <returns></returns>
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

        public void SaveFinder(BaseViewData viewData)
        {
            Finder f = new Finder();
            viewData.ExportPropertiesValuesToModel(f);

            ((IFinderRepository)_repository).Update(f);
            Messenger.NotifyColleagues(MessageTypes.MSG_MANAGER_EDIT, f);
        }
    }
}
