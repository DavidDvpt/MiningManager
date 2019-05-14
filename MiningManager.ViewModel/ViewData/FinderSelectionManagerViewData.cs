using System.Collections.ObjectModel;

namespace MiningManager.ViewModel
{
    class FinderSelectionManagerViewData : BaseViewData
    {
        public ObservableCollection<FinderItemListViewData> Items
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
