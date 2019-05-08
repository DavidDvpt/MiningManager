using MiningManager.Repository.Interfaces;
using MiningManager.ViewModel;
using MiningManager.ViewModel.ControllerInterfaces;

namespace MiningManager.Controller
{
    public class ContainerController : BaseController, IContainerController
    {
        private IContainerRepository _mainWindowService;

        public ContainerController(IContainerRepository mws)
        {
            _mainWindowService = mws;
        }

        public MenuViewModel ShowViewMenu()
        {
            throw new System.NotImplementedException();
        }

        public StatusViewModel ShowViewStatus()
        {
            throw new System.NotImplementedException();
        }

        public void Start()
        {
            ShowViewMainWindow();
        }

        #region Affichage vue Principale

        private void ShowViewMainWindow()
        {
            //ViewWindow v = GetViewMainWindow();
            //v.Show();
        }

        //private MainWindow GetViewMainWindow()
        //{
        //    MainWindow v = new MainWindow();
        //    MainWindowViewModel mv = new MainWindowViewModel(this, v);
        //    return v;
        //}

        #endregion

        #region Afficage Elements de fenetre

        //public MenuViewModel ShowViewMenu()
        //{
        //    MenuViewModel mv = GetViewMenu();
        //    return mv;
        //}

        //public StatusViewModel ShowViewStatus()
        //{
        //    StatusViewModel vm = GetViewStatus();

        //    return vm;
        //}

        //public FinderMgrViewModel ShowFinderMgrViewModel()
        //{
        //    FinderMgrViewModel vm = GetFinderViewModel();

        //    return vm;
        //}

        //private FinderMgrViewModel GetFinderViewModel()
        //{
        //    IFinderMgrController c = new FinderMgrController(new FinderMgrService());
        //    GeneralMgrView v = new GeneralMgrView();
        //    FinderMgrViewModel vm = new FinderMgrViewModel(c, v);

        //    return vm;
        //}

        #endregion

        //private MenuViewModel GetViewMenu()
        //{
        //    MenuController c = new MenuController(new MenuService());
        //    MenuView v = new MenuView();

        //    return new MenuViewModel(c, v);
        //}

        //private StatusViewModel GetViewStatus()
        //{
        //    StatusController c = new StatusController(new StatusService());
        //    StatusView v = new StatusView();

        //    return new StatusViewModel(c, v);
        //}
    }
}
