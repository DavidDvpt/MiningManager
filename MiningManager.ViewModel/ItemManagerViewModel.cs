using MiningManager.Messengers;
using MiningManager.ViewModel.ControllerInterfaces;
using System;

namespace MiningManager.ViewModel
{
    public abstract class ItemManagerViewModel : BaseViewModel
    {
        public ItemManagerViewModel(IController controller) : base(controller)
        {
            UpdateCommand = new RelayCommand(UpdateExecute, UpdateCanExecute);
            CreateCommand = new RelayCommand(CreateExecute, CreateCanExecute);
            SubmitCommand = new RelayCommand(SubmitExecute, SubmitCanExecute);
            CancelCommand = new RelayCommand(CancelExecute, CancelCanExecute);

            Controller.Messenger.Register(MessageTypes.MSG_MANAGER_EDIT, new Action<Message>(RefreshList));
        }

        #region Commands

        public RelayCommand UpdateCommand { get; protected set; }
        public RelayCommand CreateCommand { get; protected set; }
        public RelayCommand SubmitCommand { get; protected set; }
        public RelayCommand CancelCommand { get; protected set; }

        #region ExecuteMethods

        public abstract void UpdateExecute(object parameter = null);
        public abstract void CreateExecute(object parameter = null);
        public abstract void SubmitExecute(object parameter = null);
        public  void CancelExecute(object parameter = null)
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

        public BaseViewData SelectedItem
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

        public BaseViewModel CurrentEditViewModel
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

        protected abstract void RefreshList();
        protected void RefreshList(Message message)
        {
            RefreshList();
            message.HandledStatus = MessageHandledStatus.HandledContinue;
        }
    }
}
