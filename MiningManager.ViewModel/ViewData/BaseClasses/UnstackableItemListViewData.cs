using System;

namespace MiningManager.ViewModel
{
    public abstract class UnstackableItemListViewData : InWorldItemListViewData
    {
        private decimal _decay;
        public bool IsLimited { get; set; }    
        public decimal Decay
        {
            get => GetGoodDecimalPrecision(_decay, 3);
            set { _decay = value; }
        }

        public string Code { get; set; }

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
