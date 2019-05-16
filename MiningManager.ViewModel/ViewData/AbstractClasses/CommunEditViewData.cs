namespace MiningManager.ViewModel
{
    public abstract class CommunEditViewData : BaseViewData
    {
        public int _id;

        public string Nom
        {
            get => GetValue(() => Nom);
            set
            {
                if (Nom != value)
                {
                    SetValue(() => Nom, value);
                }
            }
        }

        public int GetId()
        {
            return _id;
        }
    }
}
