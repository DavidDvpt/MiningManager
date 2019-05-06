using MiningManager.Messengers;

namespace MiningManager.Controller
{
    public interface IController
    {
        Messenger Messenger { get; }
    }
}
