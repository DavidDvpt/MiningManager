using MiningManager.Model;
using System.Collections.ObjectModel;

namespace MiningManager.ViewModel
{
    /// <summary>
    /// Liste generique visible dans le viewdata
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface ISelectionListViewData<T>
         where T : BaseViewData
    {
        ObservableCollection<T> Items { get; set; }
    }
}
