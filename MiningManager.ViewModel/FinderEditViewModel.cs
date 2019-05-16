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
        }

        private void CreateViewData(int selectedId)
        {
            ViewData = _finderManagerController.ConstructFinderViewData(selectedId);
        }
    }
}
