using MiningManager.Messengers;

namespace MiningManager.Controller
{
    public abstract class BaseController : IController
    {
        public Messenger Messenger => Messenger.Instance;
    }
}
