namespace MiningManager.ViewModel
{
    public abstract class UnstackableItemListViewData : InWorldItemListViewData
    {
        public bool IsLimited { get; set; }
        //{
        //    get => GetValue(() => IsLimited);
        //    set
        //    {
        //        if (IsLimited != value)
        //        {
        //            SetValue(() => IsLimited, value);
        //        }
        //    }
        //}

        public string Code { get; set; }
        //{
        //    get => GetValue(() => Code);
        //    set
        //    {
        //        if (Code != value)
        //        {
        //            SetValue(() => Code, value);
        //        }
        //    }
        //}
    }
}
