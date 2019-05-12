using System.Collections.ObjectModel;
using MiningManager.Messengers;
using MiningManager.ViewModel.ControllerInterfaces;
using MiningManager.ViewModel.ViewData;

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
        public abstract void CancelExecute(object parameter = null);

        #endregion

        #region CanExecute Methods

        public bool UpdateCanExecute(object parameter = null)
        {
            return (CurrentSelectedItemForEdit == null) && (SelectedItem != null);
        }
        public bool CreateCanExecute(object parameter = null)
        {
            return !CancelCanExecute();
        }
        public bool SubmitCanExecute(object parameter = null)
        {
            return Errors == 0;
        }
        public bool CancelCanExecute(object parameter = null)
        {
            return CurrentSelectedItemForEdit != null;
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

        public BaseViewModel CurrentSelectedItemForEdit
        {
            get => GetValue(() => CurrentSelectedItemForEdit);
            set
            {
                if (CurrentSelectedItemForEdit != value)
                {
                    SetValue(() => CurrentSelectedItemForEdit, value);
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
