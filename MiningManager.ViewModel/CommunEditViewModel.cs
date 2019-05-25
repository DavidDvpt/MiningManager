using MiningManager.Model;
using MiningManager.ViewModel.ControllerInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiningManager.ViewModel
{
    /// <summary>
    /// ViewModel Généric de modification d'un item Entropia
    /// </summary>
    /// <typeparam name="S">ViewModel de l'item à EditerViewData de l'item utilisé dans la liste</typeparam>
    /// <typeparam name="T">ViewData de l'item à Editer</typeparam>
    /// <typeparam name="U">Entité Modele</typeparam>
    /// <typeparam name="V">ViewData de l'item ds la list</typeparam>
    /// <typeparam name="W">Viewdata de la liste d'items/typeparam>
    public class CommunEditViewModel<S, T, U, V, W> : BaseViewModel, IManagerAutoGeneratingClasses
        where S : BaseViewModel, new()
        where T : BaseViewData, new()
        where U : Commun, new()
        where V : BaseViewData, new()
        where W : BaseViewData, ISelectionListViewData<V>, new()
    {
        private ICommunManagerController<S, T, U, V> _genericManagerController
            => (ICommunManagerController<S, T, U, V>)Controller;

        public void Init(IController controller, int selectedId, bool nouveau)
        {
            throw new NotImplementedException();
        }
    }
}
