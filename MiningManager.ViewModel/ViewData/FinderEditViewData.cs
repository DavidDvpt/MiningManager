namespace MiningManager.ViewModel
{
    public class FinderEditViewData : ToolEditViewData, IItemManagerViewData
    {
        public decimal Depth
        {
            get => GetValue(() => Depth);
            set
            {
                if (Depth != value)
                {
                    SetValue(() => Depth, value);
                }
            }
        }

        public decimal Range
        {
            get => GetValue(() => Range);
            set
            {
                if (Range != value)
                {
                    SetValue(() => Range, value);
                }
            }
        }

        public short BasePecSearch
        {
            get => GetValue(() => BasePecSearch);
            set
            {
                if (BasePecSearch != value)
                {
                    SetValue(() => BasePecSearch, value);
                }
            }
        }
    }
}
