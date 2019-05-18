using MiningManager.ViewModel.AttributValidation;
using System.ComponentModel.DataAnnotations;

namespace MiningManager.ViewModel
{
    public abstract class CommunEditViewData : BaseViewData
    {
        public int _id;

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

        public int GetId()
        {
            return _id;
        }
    }
}
