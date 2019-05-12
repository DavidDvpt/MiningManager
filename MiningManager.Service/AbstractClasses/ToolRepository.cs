using MiningManager.Model;

namespace MiningManager.Repository
{
    public abstract class ToolRepository<T> : UnstackableRepository<T>, IToolRepository<T>
        where T : Tool, new()
    {
    }
}
