using MiningManager.Model;
using System.ComponentModel.DataAnnotations;

namespace MiningManager.ViewModel.ViewData
{
    public class ModeleEditViewData : CommunEditViewData
    {
        [Required]
        public Categorie Categorie
        {
            get { return GetValue(() => Categorie); }
            set
            {
                SetValue(() => Categorie, value);
                CategorieId = Categorie.Id;
            }
        }

        public int CategorieId
        {
            get { return GetValue(() => CategorieId); }
            set
            {
                SetValue(() => CategorieId, value);
            }
        }
    }
}
