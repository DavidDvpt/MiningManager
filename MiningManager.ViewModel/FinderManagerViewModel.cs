using MiningManager.Model;
using MiningManager.ViewModel.ControllerInterfaces;

namespace MiningManager.ViewModel
{
    public class FinderManagerViewModel : GeneralManagerViewModel<FinderEditViewModel, FinderEditViewData, Finder, FinderItemListViewData, ManagerFinderListViewData>
    {
        public FinderManagerViewModel(IController controller) : base(controller)
        {
        }
    }
}