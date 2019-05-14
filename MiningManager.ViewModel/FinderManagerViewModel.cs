using MiningManager.ViewModel.ControllerInterfaces;
using System;
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

        public ObservableCollection<FinderItemListViewData> ItemsListViewData
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

        public override void CancelExecute(object parameter = null)
        {
            throw new NotImplementedException();
        }

        public override void CreateExecute(object parameter = null)
        {
            throw new NotImplementedException();
        }

        public override void SubmitExecute(object parameter = null)
        {
            throw new NotImplementedException();
        }

        public override void UpdateExecute(object parameter = null)
        {
            throw new NotImplementedException();
        }

        protected override void RefreshList()
        {
            FinderSelectionManagerViewData selection = new FinderSelectionManagerViewData();
            selection.Items = _itemManagerController.DataViewFinderList();
            ViewData = selection;
        }
    }
}
