using MiningManager.ViewModel.ControllerInterfaces;

namespace MiningManager.ViewModel
{
    public interface IManagerAutoGeneratingClasses
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="controller"></param>
        /// <param name="selectedId"></param>
        /// <param name="nouveau"></param>
        void Init(IController controller, int selectedId, bool nouveau);
    }
}
