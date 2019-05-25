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
    public class EntityMgrController<S, T, U, V> : BaseController, IEntityMgrController<S, T, U, V>
        where S : BaseViewModel, IManagerAutoGeneratingClasses, new()
        where T : BaseViewData, new()
        where U : Commun, new()
        where V : BaseViewData, new()
    {
        private CommunRepository<U> _genericRepository => (CommunRepository<U>)_repository;

        #region Constructeurs

        public EntityMgrController(IBaseRepository repository)
        {
            _repository = repository;
        }

        #endregion

        #region Edition Generique d'item

        /// <summary>
        /// Cree le viewModel d'edition de l'item selectionné
        /// </summary>
        /// <param name="selectedItemId">Id de l'item selectionné</param>
        /// <returns></returns>
        public S ViewModelGenericEdit(int selectedItemId, bool nouveau)
        {
            S editViewModel = new S();
            editViewModel.Init(this, selectedItemId, nouveau);
            return editViewModel;
        }

        #endregion

        /// <summary>
        /// Cree une liste observable des item
        /// </summary>
        /// <returns></returns>
        public ObservableCollection<V> ObservableEntityList()
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
    }
}
