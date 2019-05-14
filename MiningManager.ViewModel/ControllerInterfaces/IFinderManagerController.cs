using System.Collections.ObjectModel;

namespace MiningManager.ViewModel.ControllerInterfaces
{
    public interface IFinderManagerController : IItemManagerController
    {
        ObservableCollection<FinderItemListViewData> DataViewFinderList();
    }

    
}
