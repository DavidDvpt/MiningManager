using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiningManager.ViewModel.ControllerInterfaces
{
    public interface IFinderManagerController : IItemManagerController
    {
        ObservableCollection<FinderItemListViewData> DataViewFinderList();
    }

    
}
