namespace MiningManager.ViewModel
{
    public abstract class UnstackableEditViewData : InWorldEditViewData
    {
        public bool IsLimited
        {
            get => GetValue(() => IsLimited);
        set
            {
                if (IsLimited != value)
                {
                    SetValue(() => IsLimited, value);
    }
}
        }

        public string Code
        {
            get => GetValue(() => Code);
            set
            {
                if (Code != value)
                {
                    SetValue(() => Code, value);
                }
            }
        }
    }
}
