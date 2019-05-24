using MiningManager.Model;

namespace MiningManager.ViewModel
{
    public class FinderEditViewModel : GenericEditViewModel<FinderEditViewModel, FinderEditViewData, Finder, FinderItemListViewData, FinderListMgrViewData>
    {
        protected override void SaveItem()
        {
            SaveUnstackable();
        }
    }
}
