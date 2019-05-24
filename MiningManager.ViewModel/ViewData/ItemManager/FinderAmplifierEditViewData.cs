using System.ComponentModel.DataAnnotations;

namespace MiningManager.ViewModel.ViewData
{
    public class FinderAmplifierEditViewData : UnstackableEditViewData
    {
        [Range(1,100, ErrorMessage = "Le coefficient est compris entre 1 et 100")]
        public decimal Coefficient
        {
            get => GetValue(() => Coefficient);
            set
            {
                if (Coefficient != value)
                {
                    SetValue(() => Coefficient, value);
                }
            }
        }
    }
}
