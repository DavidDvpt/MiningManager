using MiningManager.Model;
using MiningManager.ViewModel.ViewData;
using System;

namespace MiningManager.ViewModel
{
    public class MaterialModeleEditViewModel : InWorldEditViewModel<MaterialModeleEditViewModel, MaterialModeleEditViewData, Modele, MaterialModeleItemListViewData, MaterialModeleListMgrViewData>
    {
        protected override void SaveItem()
        {
            throw new NotImplementedException();
        }
    }
}
