using MiningManager.Model;
using MiningManager.ViewModel.ViewData;
using System;

namespace MiningManager.ViewModel
{
    public class ModeleEditViewModel : EntityEditViewModel<ModeleEditViewModel, ModeleEditViewData, Modele, ModeleListItemViewData, ModeleListViewData>
    {
        protected override void SaveEntity()
        {
            throw new NotImplementedException();
        }
    }
}
