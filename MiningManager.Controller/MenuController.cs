using MiningManager.Repository;
using MiningManager.View;
using MiningManager.ViewModel;
using MiningManager.ViewModel.ControllerInterfaces;
using System.Windows.Controls;

namespace MiningManager.Controller
{
    public class MenuController : BaseController, IMenuController
    {
        private static IMenuRepository _menuRepository;

        #region Constructeurs

        public MenuController(IMenuRepository menuRepository)
        {
            _menuRepository = menuRepository;
        }

        #endregion

        public void Start()
        {
            ShowViewMenu();
        }

        private void ShowViewMenu()
        {
            MenuView v = GetViewMenu();
            v.ShowInWindow(false, "Test", 600, 400, Dock.Top, null);
        }

        private MenuView GetViewMenu()
        {
            MenuView v = new MenuView();
            MenuViewModel vm = new MenuViewModel(this, v);

            return v;
        }
    }
}
