﻿using MiningManager.Messengers;
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
    public class GenericEditViewModel<S, T, U, V, W> : BaseViewModel, IManagerEditClasses
        where S : BaseViewModel, new()
        where T : BaseViewData, new()
        where U : Commun, new()
        where V : BaseViewData, new()
        where W : BaseViewData, ISelectionListVewData<V>, new()
    {
        private IItemManagerController<S, T, U, V, W> _genericManagerController
            => (IItemManagerController< S, T, U, V, W >)Controller;

        #region Constructeurs et Init

        /// <summary>
        /// Obligation d'initialiser la classe avec l'appel de la méthode Init
        /// </summary>
        public GenericEditViewModel()
        {
        }

        public GenericEditViewModel(IController controller) : base(controller)
        {
        }

        public GenericEditViewModel(IController controller, int selectedId) : base(controller)
        {
            Init(controller, selectedId);
        }

        public void Init(IController controller, int selectedId)
        {
            Controller = controller;
            CreateViewData(selectedId);
            _genericManagerController.Messenger.Register(MessageTypes.MSG_MANAGER_SAVE, SaveItem);
        }

        #endregion

        private void CreateViewData(int selectedId)
        {
            ViewData = _genericManagerController.ConstructGenericViewData(selectedId);
        }

        private void SaveItem()
        {
            _genericManagerController.SaveItem(ViewData);
            _genericManagerController.Messenger.DeRegister(this);
        }


    }
}