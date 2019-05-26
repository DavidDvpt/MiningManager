﻿using MiningManager.Model;
using System.Collections.ObjectModel;

namespace MiningManager.ViewModel.ControllerInterfaces
{
    /// <summary>
    /// Interface générique 
    /// </summary>
    /// <typeparam name="S">ViewModel de l'item à EditerViewData de l'item utilisé dans la liste</typeparam>
    /// <typeparam name="T">ViewData de l'item à Editer</typeparam>
    /// <typeparam name="U">Entité Modele</typeparam>
    /// <typeparam name="V">ViewData de l'item ds la list</typeparam>
    public interface IEntityMgrController<S, T, U, V> : IController
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="selectedItemId">id de l'item selectionné</param>
        /// <param name="nouveau">nouvel item ou non</param>
        /// <returns></returns>
        S ConstructGenericEditViewModel(int selectedItemId = 0, bool nouveau = false);

        T ConstructGenericEditViewData(int selectedItemId = 0);

        ObservableCollection<V> DataViewGenericList();

        void SaveEntity(BaseViewData viewData, bool nouveau);
    }
}
