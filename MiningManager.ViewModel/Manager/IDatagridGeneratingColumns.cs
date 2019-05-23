using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace MiningManager.ViewModel
{
    public interface IDatagridGeneratingColumns
    {
        void SetValues(DataGridColumn column);


        void DataGridColumnManagment(ObservableCollection<DataGridColumn> columns);
    }
}
