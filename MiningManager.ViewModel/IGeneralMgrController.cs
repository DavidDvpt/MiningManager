using MiningManager.ViewModel.ControllerInterfaces;
using System.Collections.ObjectModel;

namespace MiningManager.ViewModel
{
    public interface IGeneralMgrController<S, T, V> : IController
        where S : BaseViewModel, new()
        where T : BaseViewData, new()
        where V : BaseViewData, new()
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="selectedItemId">id de l'item selectionné</param>
        /// <param name="nouveau">nouvel item ou non</param>
        /// <returns></returns>
        S ConstructGenericEditViewModel(int selectedItemId = 0, bool nouveau = false);

        T ConstructGenericEditViewData(int selectedItemId = 0);

        ObservableCollection<V> DataViewGenericList();
    }
}
