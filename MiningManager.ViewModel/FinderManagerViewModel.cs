using MiningManager.Model;
using MiningManager.ViewModel.ControllerInterfaces;

namespace MiningManager.ViewModel
{
    public class FinderManagerViewModel : BaseViewModel, IItemEditViewModel//ItemManagerViewModel<FinderManagerViewModel, FinderEditViewData, Finder, FinderItemListViewData, ManagerFinderListViewData>
    {
        public FinderManagerViewModel()
        {

        }

        public FinderManagerViewModel(IController controller) : base(controller)
        {
        }

        public void Init(IController controller, int selectedId)
        {
            throw new System.NotImplementedException();
        }
    }
}