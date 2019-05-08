using MiningManager.Messengers;
using MiningManager.ViewModel.ControllerInterfaces;

namespace MiningManager.Controller
{
    public abstract class BaseController : IController
    {
        public Messenger Messenger => Messenger.Instance;
    }
}
