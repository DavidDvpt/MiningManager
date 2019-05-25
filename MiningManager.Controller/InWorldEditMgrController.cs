using MiningManager.ViewModel;
using MiningManager.Model;
using MiningManager.ViewModel.ControllerInterfaces;
using MiningManager.Repository;
using MiningManager.Messengers;

namespace MiningManager.Controller
{
    public class InWorldEditMgrController<S, T, U, V> : BaseController, IEntityEditMgrController<S, T, U, V>
        where S : BaseViewModel, new()
        where T : BaseViewData, new()
        where U : InWorld, new()
        where V : BaseViewData, new()
    {
        private InWorldRepository<U> _genericRepository => (InWorldRepository<U>)_repository;

        #region Constructeurs

        public InWorldEditMgrController(IBaseRepository repository)
        {
            _repository = repository;
        }

        #endregion

        /// <summary>
        /// crée un viewdata à partir de l'id de l'item selectionné
        /// </summary>
        /// <param name="selectedItemId">Id de l'item selectionné</param>
        /// <returns></returns>
        public T ConstructGenericEditViewData(int selectedItemId = 0)
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
        /// 
        /// </summary>
        /// <param name="viewData"></param>
        /// <param name="nouveau"></param>
        public void SaveItem(BaseViewData viewData, bool nouveau)
        {
            U item = new U();
            viewData.ExportPropertiesValuesToModel(item);

            if (nouveau)
            {
                item.Modele = _genericRepository.GetModele();
                _genericRepository.Add(item);
            }
            else
            {
                _genericRepository.Update(item);
            }

            Messenger.NotifyColleagues(MessageTypes.MSG_MANAGER_EDIT, item);
        }
    }
}
