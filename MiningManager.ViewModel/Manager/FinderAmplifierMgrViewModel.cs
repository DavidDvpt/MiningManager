using MiningManager.Model;
using MiningManager.ViewModel.ControllerInterfaces;
using MiningManager.ViewModel.ViewData;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace MiningManager.ViewModel
{
    public class FinderAmplifierMgrViewModel : InWorldMgrViewModel<FinderAmplifierEditViewModel, FinderAmplifierEditViewData, FinderAmplifier, FinderAmplifierItemListViewData, FinderAmplifierListMgrViewData>, IDatagridGeneratingColumns
    {
        public FinderAmplifierMgrViewModel(IController controller) : base(controller)
        {
        }
        public void SetValues(DataGridColumn column)
        {
            switch (column.Header.ToString())
            {
                case "Nom":
                    column.DisplayIndex = 0;
                    column.Width = 200;
                    break;
                case "Code":
                    column.DisplayIndex = 0;
                    break;
                case "IsLimited":
                    column.DisplayIndex = 1;
                    break;
                case "Value":
                    column.DisplayIndex = 1;
                    break;
                case "Decay":
                    column.DisplayIndex = 1;
                    break;
                case "Coefficient":
                    column.DisplayIndex = 6;
                    break;
                case "TotalUse":
                    column.DisplayIndex = 7;
                    break;
                case "Id":
                case "ModeleId":
                case "Error":
                    column.DisplayIndex = 8;
                    column.Visibility = Visibility.Hidden;
                    break;
            }
        }

        public void DataGridColumnManagment(ObservableCollection<DataGridColumn> columns)
        {
            foreach (DataGridColumn c in columns)
            {
                SetValues(c);
            }
        }
    }
}
