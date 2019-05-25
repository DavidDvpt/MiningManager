using MiningManager.Model;

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
    public interface ICommunMgrController<S, T, U, V> : IGeneralMgrController<S, T, V>
        where S : BaseViewModel, new()
        where T : BaseViewData, new()
        where U : Commun
        where V : BaseViewData, new()
    {
        void SaveCommun(BaseViewData viewData, bool nouveau);
    }
}
