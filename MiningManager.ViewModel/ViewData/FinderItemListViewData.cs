using System;

namespace MiningManager.ViewModel
{
    public class FinderItemListViewData : ToolListItemViewData
    {
        public decimal Depth { get; set; }

        public decimal Range { get; set; }

        public short BasePecSearch { get; set; }
    }
}
