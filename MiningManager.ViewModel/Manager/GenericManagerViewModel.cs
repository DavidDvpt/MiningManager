using MiningManager.Messengers;
using MiningManager.Model;
using MiningManager.ViewModel.ControllerInterfaces;
using System;
using System.Linq;

namespace MiningManager.ViewModel
{
    /// <summary>
    /// ViewModel Généric de modification des items Entropia
    /// </summary>
    /// <typeparam name="S">ViewModel de l'item à EditerViewData de l'item utilisé dans la liste</typeparam>
    /// <typeparam name="T">ViewData de l'item à Editer</typeparam>
    /// <typeparam name="U">Entité Modele</typeparam>
    /// <typeparam name="V">ViewData de l'item ds la list</typeparam>
    /// <typeparam name="W">Viewdata de la liste d'items/typeparam>
    public class GenericManagerViewModel<S, T, U, V, W> : BaseViewModel
        where S : BaseViewModel, new()
        where T : CommunEditViewData, new()
        where U : InWorld, new()
        where V : CommunItemListViewData, new()
        where W : BaseViewData, ISelectionListViewData<V>, new()
    {
        public IItemManagerController<S, T, U, V, W> _itemManagerController
            => (IItemManagerController < S, T, U, V, W >)Controller;

        #region Constructeurs

        public GenericManagerViewModel(IController controller) : base(controller)
        {
            UpdateCommand = new RelayCommand(UpdateExecute, UpdateCanExecute);
            CreateCommand = new RelayCommand(CreateExecute, CreateCanExecute);
            SubmitCommand = new RelayCommand(SubmitExecute, SubmitCanExecute);
            CancelCommand = new RelayCommand(CancelExecute, CancelCanExecute);
            Controller.Messenger.Register(MessageTypes.MSG_MANAGER_EDIT, new Action<Message>(RefreshList));

            Init();
            RefreshList();
        }

        private void Init()
        {
            W selection = new W();
            ViewData = selection;
        }

        #endregion

        #region Commands

        public RelayCommand UpdateCommand { get; protected set; }
        public RelayCommand CreateCommand { get; protected set; }
        public RelayCommand SubmitCommand { get; protected set; }
        public RelayCommand CancelCommand { get; protected set; }

        #region ExecuteMethods

        public void UpdateExecute(object parameter = null)
        {
            CurrentEditViewModel = _itemManagerController.ConstructGenericEditViewModel(((V)SelectedItem).Id);
        }
        public void CreateExecute(object parameter = null)
        {
            CurrentEditViewModel = _itemManagerController.ConstructGenericEditViewModel();
        }
        public void SubmitExecute(object parameter = null)
        {
            _itemManagerController.Messenger.NotifyColleagues(MessageTypes.MSG_MANAGER_SAVE);
            CurrentEditViewModel = null;
        }
        public void CancelExecute(object parameter = null)
        {
            CurrentEditViewModel = null;
            SelectedItem = null;
        }

        #endregion

        #region CanExecute Methods

        public bool UpdateCanExecute(object parameter = null)
        {
            return (CurrentEditViewModel == null) && (SelectedItem != null);
        }
        public bool CreateCanExecute(object parameter = null)
        {
            return !CancelCanExecute();
        }
        public bool SubmitCanExecute(object parameter = null)
        {
            return Errors == 0 && CurrentEditViewModel != null;
        }
        public bool CancelCanExecute(object parameter = null)
        {
            return CurrentEditViewModel != null;
        }

        #endregion

        #endregion

        #region Bindables properties

        public U ItemsListViewData
        {
            get => GetValue(() => ItemsListViewData);
            set
            {
                if (ItemsListViewData != value)
                {
                    SetValue(() => ItemsListViewData, value);
                }
            }
        }

        public V SelectedItem
        {
            get => GetValue(() => SelectedItem);
            set
            {
                if (SelectedItem != value)
                {
                    SetValue(() => SelectedItem, value);
                }
            }
        }

        public S CurrentEditViewModel
        {
            get => GetValue(() => CurrentEditViewModel);
            set
            {
                if (CurrentEditViewModel != value)
                {
                    SetValue(() => CurrentEditViewModel, value);
                }
            }
        }

        #endregion

        protected void RefreshList()
        {
            ((ISelectionListViewData<V>)ViewData).Items = _itemManagerController.DataViewGenericList();
        }
        protected void RefreshList(Message message)
        {
            RefreshList();
            message.HandledStatus = MessageHandledStatus.HandledContinue;
        }

    }
}
