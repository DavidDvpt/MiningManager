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

        }
    }
}
