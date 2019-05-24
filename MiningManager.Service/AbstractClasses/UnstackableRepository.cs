using MiningManager.Model;

namespace MiningManager.Repository
{
    public abstract class UnstackableRepository<T> : InWorldRepository<T>, IUnstackableRepository<T>
        where T : Unstackable, new()
    {
    }
}
