using System.Collections.ObjectModel;

namespace MiningManager.ViewModel
{
    public class ManagerGenericItemListViewData<T> : BaseViewData, ISelectionListViewData<T>
        where T : BaseViewData
    {
        public ObservableCollection<T> Items
        {
            get => GetValue(() => Items);
            set
            {
                if (Items != value)
                {
                    SetValue(() => Items, value);
                }
            }
        }
    }
}
