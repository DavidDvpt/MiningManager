using MiningManager.Model;
namespace MiningManager.Repository
{
    public abstract class InWorldRepository<T> : CommunRepository<T>, IInWorldRepository<T>
        where T : InWorld, new()
    {
    }
}
