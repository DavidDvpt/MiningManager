using MiningManager.Model;
using System.Collections.ObjectModel;

namespace MiningManager.ViewModel
{
    public interface ISelectionListViewData<T>
         where T : BaseViewData
    {
        ObservableCollection<T> Items { get; set; }
    }
}
