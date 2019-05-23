﻿using MiningManager.Model;
using MiningManager.Repository;
using MiningManager.ViewModel;
using MiningManager.ViewModel.ControllerInterfaces;

namespace MiningManager.Controller
{
    public class ContainerController : BaseController, IContainerController
    {


        public void Start()
        {
        }

        public FinderManagerViewModel ConstructFinderMgrViewModel()
        {
            InWorldRepository<Finder> ifr = new InWorldRepository<Finder>();

            IItemManagerController<FinderEditViewModel, FinderEditViewData, Finder, FinderItemListViewData, ManagerFinderListViewData> itemManagerController =
                new ItemManagerController<FinderEditViewModel, FinderEditViewData, Finder, FinderItemListViewData, ManagerFinderListViewData>(ifr);

            return new FinderManagerViewModel(itemManagerController);
        }
    }
}
