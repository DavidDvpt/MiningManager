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
            ShowViewStatus();
        }

        private void ShowViewStatus()
        {
            StatusView v = GetViewStatus();
            v.ShowInWindow(false, "Test", 600, 400, Dock.Bottom, null);
        }

        private StatusView GetViewStatus()
        {
            StatusView v = new StatusView();
            StatusViewModel vm = new StatusViewModel(this, v);

            return v;
        }
    }
}
