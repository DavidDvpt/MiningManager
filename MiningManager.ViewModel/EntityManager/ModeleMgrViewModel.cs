﻿using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using MiningManager.Model;
using MiningManager.ViewModel.ControllerInterfaces;
using MiningManager.ViewModel.ViewData;

namespace MiningManager.ViewModel
{
    public class ModeleMgrViewModel : EntityMgrViewModel<ModeleEditViewModel, ModeleEditViewData, Modele, ModeleListItemViewData, ModeleListViewData>, IDatagridGeneratingColumns
    {
        public ModeleMgrViewModel(IController controller) : base(controller)
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
                case "CategorieNom":
                    column.DisplayIndex = 0;
                    //column.CellStyle. = 200;
                    break;
                case "Id":
                case "Error":
                case "Categorie":
                    column.DisplayIndex = 1;
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

        public override bool UpdateCanExecute(object parameter = null)
        {
            return false;
        }

    }
}