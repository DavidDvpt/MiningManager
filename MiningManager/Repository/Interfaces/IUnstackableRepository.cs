using MiningManager.Model;

namespace MiningManager.Repository
{
    public interface IUnstackableRepository<T> : IInWorldRepository<T>
        where T : Unstackable, new()
    {
    }
}
