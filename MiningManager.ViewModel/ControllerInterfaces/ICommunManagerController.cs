using MiningManager.Model;
using System.Collections.ObjectModel;

namespace MiningManager.ViewModel.ControllerInterfaces
{
    /// <summary>
    /// Interface générique 
    /// </summary>
    /// <typeparam name="S">ViewModel de l'item à EditerViewData de l'item utilisé dans la liste</typeparam>
    /// <typeparam name="T">ViewData de l'item à Editer</typeparam>
    /// <typeparam name="U">Entité Modele</typeparam>
    /// <typeparam name="V">ViewData de l'item ds la list</typeparam>
    /// <typeparam name="W">Viewdata de la liste d'items/typeparam>
    public interface ICommunManagerController<S, T, U, V> : IController
        where S : BaseViewModel, new()
        where T : BaseViewData, new()
        where U : Commun, new()
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

        void SaveItem(BaseViewData viewData, bool nouveau);
    }
}
