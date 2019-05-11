using MiningManager.Messengers;
using MiningManager.Repository;
using MiningManager.ViewModel.ControllerInterfaces;

namespace MiningManager.Controller
{
    public abstract class BaseController : IController
    {
        public Messenger Messenger => Messenger.Instance;

        protected IBaseRepository _repository;
    }
}
