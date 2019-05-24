using MiningManager.ViewModel.ControllerInterfaces;

namespace MiningManager.ViewModel
{
    public interface IManagerAutoGeneratingClasses
    {
        void Init(IController controller, int selectedId);
    }
}
