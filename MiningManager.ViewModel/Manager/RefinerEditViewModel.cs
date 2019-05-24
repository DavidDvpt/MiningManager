using MiningManager.Model;
using MiningManager.ViewModel.ViewData;

namespace MiningManager.ViewModel
{
    public class RefinerEditViewModel : GenericEditViewModel<RefinerEditViewModel, RefinerEditViewData, Refiner, RefinerItemListViewData, RefinerListMgrViewData>
    {
        protected override void SaveItem()
        {
            SaveUnstackable();
        }
    }
}
