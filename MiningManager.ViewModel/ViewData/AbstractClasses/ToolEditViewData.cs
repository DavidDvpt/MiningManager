namespace MiningManager.ViewModel
{
    public abstract class ToolEditViewData : UnstackableEditViewData
    {
        public decimal Decay
        {
            get => GetValue(() => Decay);
        set
            {
                if (Decay != value)
                {
                    SetValue(() => Decay, value);
    }
}
        }

        public short UsePerMin
        {
            get => GetValue(() => UsePerMin);
            set
            {
                if (UsePerMin != value)
                {
                    SetValue(() => UsePerMin, value);
                }
            }
        }
    }
}
