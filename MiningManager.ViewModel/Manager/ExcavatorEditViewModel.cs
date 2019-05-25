using MiningManager.Model;
using MiningManager.ViewModel.ViewData;

namespace MiningManager.ViewModel
{
    public class ExcavatorEditViewModel : InWorldEditViewModel<ExcavatorEditViewModel, ExcavatorEditViewData, Excavator, ExcavatorItemListViewData, ExcavatorListMgrViewData>
    {
        protected override void SaveItem()
        {
            SaveUnstackable();
        }
    }
}
