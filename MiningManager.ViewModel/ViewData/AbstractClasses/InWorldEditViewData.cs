namespace MiningManager.ViewModel
{
    public abstract class InWorldEditViewData : CommunEditViewData
    {
        public decimal Value
        {
            get => GetValue(() => Value);
        set
            {
                if (Value != value)
                {
                    SetValue(() => Value, value);
                }
            }
        }

        public int ModeleId
        {
            get => GetValue(() => ModeleId);
            set
            {
                if (Value != value)
                {
                    SetValue(() => ModeleId, value);
                }
            }
        }
    }
}
