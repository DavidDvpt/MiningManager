namespace MiningManager.ViewModel
{
    public abstract class InWorldListItemViewData : CommunListItemViewData
    {
       private decimal _value;
       public decimal Value
        {
            get => GetGoodDecimalPrecision(_value, 2);
            set { _value = value; }
        }
    }
}
