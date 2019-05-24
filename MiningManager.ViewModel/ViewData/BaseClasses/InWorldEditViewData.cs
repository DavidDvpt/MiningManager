using System.ComponentModel.DataAnnotations;

namespace MiningManager.ViewModel
{
    public abstract class InWorldEditViewData : CommunEditViewData
    {
        [Range(0, 9999.99999, ErrorMessage = "la valeur doit être entre 0,00001 et 9999,99999")]
        [Required(ErrorMessage = "La valeur ne peut pas être nulle. mettre 0 si inconnue")]
        public decimal Value
        {
            get => GetValue(() => Value);
        set
            {
                if (Value != value)
                {
                    SetValue(() => Value, GetGoodDecimalPrecision(value, 2));
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
