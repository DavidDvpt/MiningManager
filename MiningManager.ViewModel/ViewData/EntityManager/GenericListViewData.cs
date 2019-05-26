using System.Collections.ObjectModel;

namespace MiningManager.ViewModel
{
    public abstract class GenericListViewData<T> : BaseViewData, ISelectionListViewData<T>
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
