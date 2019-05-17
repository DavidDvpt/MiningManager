using MiningManager.Messengers;
using MiningManager.Model;
using MiningManager.ViewModel.ControllerInterfaces;

namespace MiningManager.ViewModel
{
    public class FinderEditViewModel : BaseViewModel, IItemEditViewModel
    {
        private IItemManagerController<FinderManagerViewModel, FinderEditViewData, Finder, FinderItemListViewData, ManagerFinderListViewData> _finderManagerController
            => (IItemManagerController< FinderManagerViewModel, FinderEditViewData, Finder, FinderItemListViewData, ManagerFinderListViewData >)Controller;

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
            Controller = controller;
            CreateViewData(selectedId);
            _finderManagerController.Messenger.Register(MessageTypes.MSG_SAVE_FINDER, SaveItem);
        }
        public void Init(IController controller, int selectedId)
        {
            Controller = controller;
            CreateViewData(selectedId);
        }

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
