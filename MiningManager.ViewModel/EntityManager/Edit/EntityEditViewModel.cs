using MiningManager.Messengers;
using MiningManager.Model;
using MiningManager.ViewModel.ControllerInterfaces;

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
    public abstract class EntityEditViewModel<S, T, U, V, W> : BaseViewModel, IManagerAutoGeneratingClasses
        where S : BaseViewModel, new()
        where T : BaseViewData, new()
        where U : InWorld, new()
        where V : BaseViewData, new()
        where W : BaseViewData, ISelectionListViewData<V>, new()
    {
        private IEntityMgrController<S, T, U, V> _genericManagerController
            => (IEntityMgrController< S, T, U, V>)Controller;

        #region Constructeurs et Init

        /// <summary>
        /// Obligation d'initialiser la classe avec l'appel de la méthode Init
        /// </summary>
        public EntityEditViewModel()
        {
        }

        public EntityEditViewModel(IController controller) : base(controller)
        {
        }

        public EntityEditViewModel(IController controller, int selectedId, bool nouveau) : base(controller)
        {
            Init(controller, selectedId, nouveau);
        }

        public void Init(IController controller, int selectedId, bool nouveau)
        {
            Controller = controller;
            CreateViewData(selectedId);
            _genericManagerController.Messenger.Register(MessageTypes.MSG_MANAGER_SAVE, SaveEntity);
            NomFormEnabled = nouveau;
        }

        #endregion

        private void CreateViewData(int selectedId)
        {
            ViewData = _genericManagerController.ConstructGenericEditViewData(selectedId);
        }

        #region Methodes bindées

        public bool NomFormEnabled
        {
            get => GetValue(() => NomFormEnabled);
            set
            {
                if (NomFormEnabled != value)
                {
                    SetValue(() => NomFormEnabled, value);
                }
            }
        }

        #endregion

        protected abstract void SaveEntity();

        protected void SaveUnstackable()
        {
            bool nouveau = ((CommunEditViewData)ViewData).Id == 0 ? true : false;
            _genericManagerController.SaveEntity(ViewData, nouveau);
            _genericManagerController.Messenger.DeRegister(this);
        }


    }
}
