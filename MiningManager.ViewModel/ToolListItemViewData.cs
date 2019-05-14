using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiningManager.ViewModel
{
    public abstract class ToolListItemViewData : UnstackableItemListViewData
    {
        public decimal Decay { get; set; }
        //{
        //    get => GetValue(() => Decay);
        //    set
        //    {
        //        if (Decay != value)
        //        {
        //            SetValue(() => Decay, value);
        //        }
        //    }
        //}

        public short UsePerMin { get; set; }
        //{
        //    get => GetValue(() => UsePerMin);
        //    set
        //    {
        //        if (UsePerMin != value)
        //        {
        //            SetValue(() => UsePerMin, value);
        //        }
        //    }
        //}
    }
}
