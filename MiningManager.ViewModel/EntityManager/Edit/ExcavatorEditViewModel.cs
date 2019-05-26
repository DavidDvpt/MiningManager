using MiningManager.Model;
using MiningManager.ViewModel.ViewData;

namespace MiningManager.ViewModel
{
    public class ExcavatorEditViewModel : EntityEditViewModel<ExcavatorEditViewModel, ExcavatorEditViewData, Excavator, ExcavatorListItemViewData, ExcavatorListViewData>
    {
        protected override void SaveEntity()
        {
            SaveUnstackable();
        }
    }
}
