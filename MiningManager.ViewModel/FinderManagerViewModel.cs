﻿using MiningManager.Messengers;
using MiningManager.ViewModel.ControllerInterfaces;
using System.Collections.ObjectModel;

namespace MiningManager.ViewModel
{
    public class FinderManagerViewModel : ItemManagerViewModel
    {
        protected IFinderManagerController _itemManagerController => (IFinderManagerController)Controller;

        public FinderManagerViewModel(IFinderManagerController controller) : base(controller)
        {
            RefreshList();
        }

        public ObservableCollection<BaseViewData> ItemsListViewData
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

        public override void CreateExecute(object parameter = null)
        {
            CurrentEditViewModel = _itemManagerController.ConstructFinderEditViewModel();
        }

        public override void SubmitExecute(object parameter = null)
        {
            _itemManagerController.Messenger.NotifyColleagues(MessageTypes.MSG_SAVE_FINDER);
            CurrentEditViewModel = null;
        }

        public override void UpdateExecute(object parameter = null)
        {
            CurrentEditViewModel = _itemManagerController.ConstructFinderEditViewModel(((FinderItemListViewData)SelectedItem).GetId());
        }

        protected override void RefreshList()
        {
            FinderSelectionManagerViewData selection = new FinderSelectionManagerViewData();
            selection.Items = _itemManagerController.DataViewFinderList();
            ViewData = selection;
        }
    }
}