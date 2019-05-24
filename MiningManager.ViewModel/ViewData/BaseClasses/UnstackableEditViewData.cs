using MiningManager.ViewModel.AttributValidation;
using System.ComponentModel.DataAnnotations;

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

        [Range(0, 9999.999, ErrorMessage = "la valeur doit être entre 0,00001 et 9999,99999")]
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

        [MaxLength(10, ErrorMessage = "La longueur maximum est de 50")]
        [Unique(ErrorMessage = "Ce nom de code est déjà utilisé")]
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
