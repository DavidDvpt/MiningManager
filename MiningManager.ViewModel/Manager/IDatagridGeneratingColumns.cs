using System.Collections.ObjectModel;
using System.Windows.Controls;

namespace MiningManager.ViewModel
{
    /// <summary>
    /// Méthodes de modifications de l'ordre des colonnes du datagrid en fonction de la liste d'item à afficher
    /// </summary>
    public interface IDatagridGeneratingColumns
    {
        void SetValues(DataGridColumn column);

        void DataGridColumnManagment(ObservableCollection<DataGridColumn> columns);
    }
}
