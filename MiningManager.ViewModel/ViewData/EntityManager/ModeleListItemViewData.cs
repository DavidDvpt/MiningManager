using MiningManager.Model;

namespace MiningManager.ViewModel.ViewData
{
    public class ModeleListItemViewData : CommunItemListViewData
    {
        public Categorie Categorie
        {
            get => GetValue(() => Categorie);
            set
            {
                if (Categorie != value)
                {
                    SetValue(() => Categorie, value);
                }
            }
        }

        public string CategorieNom => Categorie.Nom;
    }
}
