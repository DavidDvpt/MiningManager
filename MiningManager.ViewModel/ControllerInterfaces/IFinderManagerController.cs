using System.Collections.ObjectModel;

namespace MiningManager.ViewModel.ControllerInterfaces
{
    public interface IFinderManagerController : IItemManagerController
    {
        ObservableCollection<FinderItemListViewData> DataViewFinderList();

        FinderEditViewModel ConstructFinderEditViewModel(int selectedFinderId);

        BaseViewData ConstructFinderViewData(int selectedFinder);
    }

    
}
