using MiningManager.Messengers;
using MiningManager.Model;
using MiningManager.ViewModel.ControllerInterfaces;

namespace MiningManager.ViewModel
{
    public class FinderEditViewModel : BaseViewModel, IManagerEditClasses
    {
        private IItemManagerController<FinderEditViewModel, FinderEditViewData, Finder, FinderItemListViewData, ManagerFinderListViewData> _finderManagerController
            => (IItemManagerController< FinderEditViewModel, FinderEditViewData, Finder, FinderItemListViewData, ManagerFinderListViewData >)Controller;

        #region Constructeurs et Init

        /// <summary>
        /// Obligation d'initialiser la classe avec l'appel de la méthode Init
        /// </summary>
        public FinderEditViewModel()
        {
        }

        public FinderEditViewModel(IController controller) : base(controller)
        {
        }

        public FinderEditViewModel(IController controller, int selectedId) : base(controller)
        {
            Init(controller, selectedId);
        }

        public void Init(IController controller, int selectedId)
        {
            Controller = controller;
            CreateViewData(selectedId);
            _finderManagerController.Messenger.Register(MessageTypes.MSG_MANAGER_SAVE, SaveItem);
        }

        #endregion

        private void CreateViewData(int selectedId)
        {
            ViewData = _finderManagerController.ConstructGenericViewData(selectedId);
        }

        private void SaveItem()
        {
            _finderManagerController.SaveItem(ViewData);
        }


    }
}
