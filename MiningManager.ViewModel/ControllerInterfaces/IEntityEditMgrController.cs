namespace MiningManager.ViewModel.ControllerInterfaces
{
    /// <summary>
    /// Interface générique 
    /// </summary>
    /// <typeparam name="S">ViewModel de l'item à EditerViewData de l'item utilisé dans la liste</typeparam>
    /// <typeparam name="T">ViewData de l'item à Editer</typeparam>
    /// <typeparam name="U">Entité Modele</typeparam>
    /// <typeparam name="V">ViewData de l'item ds la list</typeparam>
    public interface IEntityEditMgrController<S, T, U, V> : IController
    {

        T ConstructGenericEditViewData(int selectedItemId = 0);

        void SaveEntity(BaseViewData viewData, bool nouveau);
    }
}
