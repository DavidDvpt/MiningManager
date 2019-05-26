using System;

namespace MiningManager.ViewModel.ViewData
{    
     /// <summary>
     /// Classe utilisee pour l'affichage dans une liste. n'implemente pas la validation
     /// </summary>
    public class FinderListItemViewData : ToolListItemViewData
    {
        public decimal Depth { get; set; }

        public decimal Range { get; set; }

        public short BasePecSearch { get; set; }
    }
}
