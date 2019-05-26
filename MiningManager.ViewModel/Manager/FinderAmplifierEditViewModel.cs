using MiningManager.Model;
using MiningManager.ViewModel.ViewData;

namespace MiningManager.ViewModel
{
    public class FinderAmplifierEditViewModel : EntityEditViewModel<FinderAmplifierEditViewModel, FinderAmplifierEditViewData, FinderAmplifier, FinderAmplifierItemListViewData, FinderAmplifierListMgrViewData>
    {
        protected override void SaveItem()
        {
            SaveUnstackable();
        }
    }
}
