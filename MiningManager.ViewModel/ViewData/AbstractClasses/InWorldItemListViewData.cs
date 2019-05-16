using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiningManager.ViewModel
{
    public abstract class InWorldItemListViewData : CommunItemListViewData
    {
       public decimal Value { get; set; }
        //{
        //    get => GetValue(() => Value);
        //    set
        //    {
        //        if (Value != value)
        //        {
        //            SetValue(() => Value, value);
        //        }
        //    }
        //}
    }
}
