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

        public BaseViewModel GetExcavatorMgrViewModel()
        {
            throw new System.NotImplementedException();
        }

        public BaseViewModel GetFinderAmplifierMgrViewModel()
        {
            throw new System.NotImplementedException();
        }

        public BaseViewModel GetGeneralFinderViewModel()
        {
            throw new System.NotImplementedException();
        }

        public BaseViewModel GetRefinerMgrViewModel()
        {
            throw new System.NotImplementedException();
        }
    }
}
