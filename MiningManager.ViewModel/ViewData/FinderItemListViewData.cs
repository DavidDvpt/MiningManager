using System;

namespace MiningManager.ViewModel
{
    public class FinderItemListViewData : ToolListItemViewData, IItemManagerViewData
    {
        public decimal Depth { get; set; }
        //{
        //    get => GetValue(() => Depth);
        //    set
        //    {
        //        if (Depth != value)
        //        {
        //            SetValue(() => Depth, value);
        //        }
        //    }
        //}

        public decimal Range { get; set; }
        //{
        //    get => GetValue(() => Range);
        //    set
        //    {
        //        if (Range != value)
        //        {
        //            SetValue(() => Range, value);
        //        }
        //    }
        //}

        public short BasePecSearch { get; set; }
        //{
        //    get => GetValue(() => BasePecSearch);
        //    set
        //    {
        //        if (BasePecSearch != value)
        //        {
        //            SetValue(() => BasePecSearch, value);
        //        }
        //    }
        //}

        public int TotalUse
        {
            get
            {
                if (Decay != 0)
                {
                    decimal val = Value / (Decay / 100);
                    return (Int32)val;
                }

                return 0;
            }
        }
    }
}
