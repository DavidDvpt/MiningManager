using MiningManager.Model;
using MiningManager.Repository;
using MiningManager.ViewModel.ControllerInterfaces;
using MiningManager.ViewModel;
using System.Collections.ObjectModel;
using System.Linq;
using MiningManager.Messengers;

namespace MiningManager.Controller
{
    /// <summary>
    /// Classe générique de modification de
    /// </summary>
    /// <typeparam name="S">ViewModel de l'item à EditerViewData de l'item utilisé dans la liste</typeparam>
    /// <typeparam name="T">ViewData de l'item à Editer</typeparam>
    /// <typeparam name="U">Entité Modele</typeparam>
    /// <typeparam name="V">ViewData de l'item ds la list</typeparam>
    /// <typeparam name="W">Viewdata de la liste d'items/typeparam>
    public class CommunManagerController<S, T, U, V> : BaseController, ICommunManagerController<S, T, U, V>
        where S : BaseViewModel, IManagerAutoGeneratingClasses, new()
        where T : BaseViewData, new()
        where U : Commun, new()
        where V : BaseViewData, new()
    {
        public T ConstructGenericEditViewData(int selectedItemId = 0)
        {
            throw new System.NotImplementedException();
        }

        public S ConstructGenericEditViewModel(int selectedItemId = 0, bool nouveau = false)
        {
            throw new System.NotImplementedException();
        }

        public ObservableCollection<V> DataViewGenericList()
        {
            throw new System.NotImplementedException();
        }

        public void SaveItem(BaseViewData viewData, bool nouveau)
        {
            throw new System.NotImplementedException();
        }
    }
}
