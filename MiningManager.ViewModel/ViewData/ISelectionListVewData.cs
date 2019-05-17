using System.Collections.ObjectModel;

namespace MiningManager.ViewModel
{
    public interface ISelectionListVewData<T>
         where T : BaseViewData
    {
        ObservableCollection<T> Items { get; set; }
    }
}
