using MiningManager.Messengers;
using MiningManager.ViewModel.ControllerInterfaces;

namespace MiningManager.ViewModel
{
    public class FinderEditViewModel : BaseViewModel
    {
        private IFinderManagerController _finderManagerController => (IFinderManagerController)Controller;

        public FinderEditViewModel(IController controller) : base(controller)
        {
        }

        public FinderEditViewModel(IController controller, int selectedId) : base(controller)
        {
            Controller = controller;
            CreateViewData(selectedId);
            _finderManagerController.Messenger.Register(MessageTypes.MSG_SAVE_FINDER, SaveItem);
        }

        private void CreateViewData(int selectedId)
        {
            ViewData = _finderManagerController.ConstructFinderViewData(selectedId);
        }

        private void SaveItem()
        {
            _finderManagerController.SaveFinder(ViewData);
        }
    }
}
