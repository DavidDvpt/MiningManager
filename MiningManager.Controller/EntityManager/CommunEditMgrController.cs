using MiningManager.Messengers;
using MiningManager.Model;
using MiningManager.Repository;
using MiningManager.ViewModel;
using MiningManager.ViewModel.ControllerInterfaces;

namespace MiningManager.Controller
{
    public class CommunEditMgrController<S, T, U, V> : BaseController, IEntityEditMgrController<S, T, U, V>
        where S : BaseViewModel, new()
        where T : BaseViewData, new()
        where U : Commun, new()
        where V : BaseViewData, new()
    {
        private CommunRepository<U> _genericRepository => (CommunRepository<U>)_repository;

        #region Constructeurs

        public CommunEditMgrController(IBaseRepository repository)
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
        public void SaveEntity(BaseViewData viewData, bool nouveau)
        {
            U item = new U();
            viewData.ExportPropertiesValuesToModel(item);

            if (nouveau)
            {
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
