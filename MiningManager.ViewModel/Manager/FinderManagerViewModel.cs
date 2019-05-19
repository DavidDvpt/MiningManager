using System.Windows;
using MiningManager.Model;
using MiningManager.ViewModel.ControllerInterfaces;

namespace MiningManager.ViewModel
{
    public class FinderManagerViewModel : GenericManagerViewModel<FinderEditViewModel, FinderEditViewData, Finder, FinderItemListViewData, ManagerFinderListViewData>, IDatagridGeneratingColumns
    {
        public FinderManagerViewModel(IController controller) : base(controller)
        {
        }

        public int SetColumnIndex(string columnHeader)
        {
            int index = 0;
            switch(columnHeader)
            {
                case "Nom":
                    index = 0;
                    break;

            }

            return index;
        }

        public Visibility SetColumnVisibility(string columnHeader)
        {
            Visibility v = Visibility.Visible;

            switch (columnHeader)
            {
                case "Id":
                case "Error":
                    v = Visibility.Hidden;
                    break;
            }

            return v;
        }
    }
}