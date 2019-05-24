using System.ComponentModel.DataAnnotations;

namespace MiningManager.ViewModel.ViewData
{

    public class ExcavatorEditViewData : ToolEditViewData
    {
        [Range(0,25,ErrorMessage = "Le coefficient est compris entre 0 et 25")]
        public decimal Efficienty
        {
            get => GetValue(() => Efficienty);
            set
            {
                if (Efficienty != value)
                {
                    SetValue(() => Efficienty, value);
                }
            }
        }
    }
}
