using MiningManager.Model;

namespace MiningManager.Repository
{
    public interface IInWorldRepository<T> : ICommunRepository<T>
        where T : InWorld, new()
    {
    }
}
