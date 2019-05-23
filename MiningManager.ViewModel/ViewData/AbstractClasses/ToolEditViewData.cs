using System.ComponentModel.DataAnnotations;

namespace MiningManager.ViewModel
{
    public abstract class ToolEditViewData : UnstackableEditViewData
    {
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
