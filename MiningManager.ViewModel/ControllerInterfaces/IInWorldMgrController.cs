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
    public interface IInWorldMgrController<S, T, U, V> : IGeneralMgrController<S, T, V>
        where S : BaseViewModel, new()
        where T : BaseViewData, new()
        where U : InWorld
        where V : BaseViewData, new()
    {
        void SaveInWorld(BaseViewData viewData, bool nouveau);
    }
}
