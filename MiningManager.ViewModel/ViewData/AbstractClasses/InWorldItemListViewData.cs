using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiningManager.ViewModel
{
    public abstract class InWorldItemListViewData : CommunItemListViewData
    {
        private decimal _value;
       public decimal Value
        {
            get => GetGoodDecimalPrecision(_value, 2);
            set { _value = value; }
        }

    }
}
