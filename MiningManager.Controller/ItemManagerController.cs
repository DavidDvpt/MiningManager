using MiningManager.Model;
using MiningManager.Repository;
using MiningManager.ViewModel.ControllerInterfaces;
using MiningManager.ViewModel;
using System.Collections.ObjectModel;
using System.Linq;
using MiningManager.Messengers;

namespace MiningManager.Controller
{
    /// <summary>
    /// Classe générique de modification de
    /// </summary>
    /// <typeparam name="S">ViewModel de l'item à EditerViewData de l'item utilisé dans la liste</typeparam>
    /// <typeparam name="T">ViewData de l'item à Editer</typeparam>
    /// <typeparam name="U">Entité Modele</typeparam>
    /// <typeparam name="V">ViewData de l'item ds la list</typeparam>
    /// <typeparam name="W">Viewdata de la liste d'items/typeparam>
    class ItemManagerController<S, T, U, V, W> : BaseController, IItemManagerController<S, T, U, V, W>
        where S : BaseViewModel, IManagerEditClasses, new()
        where T : BaseViewData, new()
        where U : InWorld, new()
        where V : BaseViewData, new()
        where W : BaseViewData, ISelectionListViewData<V>, new()
    {
        private InWorldRepository<U> _genericRepository => (InWorldRepository<U>)_repository;

        #region Constructeurs

        public ItemManagerController()
        {

        }

        public ItemManagerController(InWorldRepository<U> repository)
        {
            _repository = repository;
        }

        #endregion

        public S ConstructGenericEditViewModel(int selectedItemId = 0)
        {
            S editViewModel = new S();
            editViewModel.Init(this, selectedItemId);

            return editViewModel;
        }

        /// <summary>
        /// crée un viewdata à partir de l'id de l'item selectionné
        /// </summary>
        /// <param name="selectedItemId"></param>
        /// <returns></returns>
        public T ConstructGenericViewData(int selectedItemId = 0)
        {
            T viewData = new T();
            if (selectedItemId != 0)
            {
                U model = _genericRepository.GetById(selectedItemId);
                viewData.ImportPropertiesValuesFromModel(model);
            }

            return viewData;
        }

        /// <summary>
        /// Cree une liste observable des item
        /// </summary>
        /// <returns></returns>
        public ObservableCollection<V> DataViewGenericList()
        {
            ObservableCollection<V> oc = new ObservableCollection<V>();
            V filvd;
            foreach (U item in _genericRepository.GetAll().OrderBy(x => x.Nom).ToList())
            {
                filvd = new V();
                filvd.ImportPropertiesValuesFromModel(item);
                oc.Add(filvd);
            }

            return oc;
        }

        /// <summary>
        /// Sauvegarde l'entité dans la base de donnée
        /// </summary>
        /// <param name="viewData">entité sortie du formulaire</param>
        public void SaveItem(BaseViewData viewData, bool nouveau)
        {
            U item = new U();
            viewData.ExportPropertiesValuesToModel(item);

            if (nouveau)
            {
                item.Modele = GetItemModele();
                _genericRepository.Add(item);
            }
            else
            {
                _genericRepository.Update(item);
            }
            
            Messenger.NotifyColleagues(MessageTypes.MSG_MANAGER_EDIT, item);
        }

        public Modele GetItemModele()
        {
            return _genericRepository.GetModele();
        }
    }
}
