using MiningManager.Model;
using MiningManager.ViewModel.ViewData;

namespace MiningManager.ViewModel
{
    public class FinderEditViewModel : EntityEditViewModel<FinderEditViewModel, FinderEditViewData, Finder, FinderItemListViewData, FinderListMgrViewData>
    {
        protected override void SaveItem()
        {
            SaveUnstackable();
        }
    }
}
