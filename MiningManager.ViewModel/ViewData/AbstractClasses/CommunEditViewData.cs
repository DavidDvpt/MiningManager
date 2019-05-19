using MiningManager.ViewModel.AttributValidation;
using System.ComponentModel.DataAnnotations;

namespace MiningManager.ViewModel
{
    public abstract class CommunEditViewData : BaseViewData
    {
        public int Id
        {
            get => GetValue(() => Id);
            set
            {
                if (Id != value)
                {
                    SetValue(() => Id, value);
                }
            }
        }

        [Unique(ErrorMessage = "Ce nom existe déjà")]
        [Required(ErrorMessage = "Le nom est obligatoire")]
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
    }
}
