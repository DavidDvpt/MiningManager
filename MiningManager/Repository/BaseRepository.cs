namespace MiningManager.Repository
{
    public class BaseRepository : IBaseRepository
    {
        public MiningContext Context { get; } = new MiningContext();
    }
}
