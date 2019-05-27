using MiningManager.Messengers;
using MiningManager.Model;
using MiningManager.ViewModel.ControllerInterfaces;
using MiningManager.ViewModel.ViewData;
using System;
using System.Collections.Generic;

namespace MiningManager.ViewModel
{
    public class ModeleEditViewModel : EntityEditViewModel<ModeleEditViewModel, ModeleEditViewData, Modele, ModeleListItemViewData, ModeleListViewData>
    {

        //public ModeleEditViewModel()
        //{

        //}

        public override void Init(IController controller, int selectedId, bool nouveau)
        {
            Controller = controller;
            CreateViewData(selectedId);
            LoadCategories();
            _genericManagerController.Messenger.Register(MessageTypes.MSG_MANAGER_SAVE, SaveEntity);
            NomFormEnabled = nouveau;
        }

        public List<Categorie> Categories { get; private set; }



        public void LoadCategories()
        {
            Categories = _genericManagerController.GetCategories();
        }

    }
}
