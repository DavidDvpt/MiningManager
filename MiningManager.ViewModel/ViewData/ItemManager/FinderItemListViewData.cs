using System;

namespace MiningManager.ViewModel
{    
     /// <summary>
     /// Classe utilisee pour l'affichage dans une liste. n'implemente pas la validation
     /// </summary>
    public class FinderItemListViewData : ToolListItemViewData
    {
        public decimal Depth { get; set; }

        public decimal Range { get; set; }

        public short BasePecSearch { get; set; }
    }
}
