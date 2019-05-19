using System.Windows.Controls;
using System.Windows;
using MiningManager.ViewModel;

namespace MiningManager.View
{
    /// <summary>
    /// Logique d'interaction pour ItemManagerView.xaml
    /// </summary>
    public partial class ItemManagerView : UserControl
    {
        public ItemManagerView()
        {
            InitializeComponent();
        }

        private void DgGeneric_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            e.Column.Visibility = ((IDatagridGeneratingColumns)DataContext).SetColumnVisibility(e.Column.Header.ToString());

            e.Column.DisplayIndex = ((IDatagridGeneratingColumns)DataContext).SetColumnIndex(e.Column.Header.ToString());
        }
    }
}
