using MiningManager.Repository;
using MiningManager.View;
using MiningManager.ViewModel;
using MiningManager.ViewModel.ControllerInterfaces;
using System.Windows.Controls;

namespace MiningManager.Controller
{
    public class StatusController : BaseController, IStatusController
    {
        private IStatusRepository _statusRepository;

        public StatusController(IStatusRepository statusRepository)
        {
            _statusRepository = statusRepository;
        }

        public void Start()
        {

        }
    }

}
