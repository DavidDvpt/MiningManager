using MiningManager.Model;
using MiningManager.ViewModel.ViewData;

namespace MiningManager.ViewModel
{
    public class ExcavatorEditViewModel : EntityEditViewModel<ExcavatorEditViewModel, ExcavatorEditViewData, Excavator, ExcavatorItemListViewData, ExcavatorListMgrViewData>
    {
        protected override void SaveItem()
        {
            SaveUnstackable();
        }
    }
}
