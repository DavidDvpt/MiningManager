using MiningManager.Model;

namespace MiningManager.Repository
{
    public interface IToolRepository<T> : IUnstackableRepository<T>
        where T : Tool, new()
    {
    }
}
