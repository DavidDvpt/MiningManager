﻿using System.Windows.Controls;
using System.Windows;
using MiningManager.ViewModel;

namespace MiningManager.View
{
    /// <summary>
    /// Logique d'interaction pour ItemManagerView.xaml
    /// </summary>
    public partial class EntityMgrView : ValidationErrorView
    {
        public EntityMgrView()
        {
            InitializeComponent();
        }

        private void DgGeneric_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {

            int i = dgGeneric.Columns.Count;
            //e.Column.Visibility = ((IDatagridGeneratingColumns)DataContext).SetColumnVisibility(e.Column.Header.ToString());

            //e.Column.DisplayIndex = ((IDatagridGeneratingColumns)DataContext).SetColumnIndex(e.Column.Header.ToString());
        }

        private void DgGeneric_AutoGeneratedColumns(object sender, System.EventArgs e)
        {
            ((IDatagridGeneratingColumns)DataContext).DataGridColumnManagment(dgGeneric.Columns);
        }
    }
}