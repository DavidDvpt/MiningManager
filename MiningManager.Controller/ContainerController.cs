using MiningManager.Repository.Interfaces;
using MiningManager.ViewModel;
using MiningManager.ViewModel.ControllerInterfaces;

namespace MiningManager.Controller
{
    public class ContainerController : BaseController, IContainerController
    {
        #region champs

        private IContainerRepository _mainWindowService;

        #endregion

        #region Constructeurs

        public ContainerController(IContainerRepository mws)
        {
            _mainWindowService = mws;
        }


        #endregion

        public void Start()
        {

        }
        public BaseViewModel GetItemManagerViewModel(string parameter)
        {
            IItemManagerController ic = new ItemManagerController();
            return new ItemManagerViewModel(ic, parameter);
        }

    }
}
