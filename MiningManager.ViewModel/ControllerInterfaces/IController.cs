using MiningManager.Messengers;

namespace MiningManager.ViewModel.ControllerInterfaces
{
    public interface IController
    {
        Messenger Messenger { get; }
    }
}
