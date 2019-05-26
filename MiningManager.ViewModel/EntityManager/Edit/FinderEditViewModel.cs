using MiningManager.Model;
using MiningManager.ViewModel.ViewData;

namespace MiningManager.ViewModel
{
    public class FinderEditViewModel : EntityEditViewModel<FinderEditViewModel, FinderEditViewData, Finder, FinderListItemViewData, FinderListViewData>
    {
        protected override void SaveItem()
        {
            SaveUnstackable();
        }
    }
}
