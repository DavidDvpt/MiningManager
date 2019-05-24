using System;

namespace MiningManager.Repository
{
    public class BaseRepository : IBaseRepository
    {
        public MiningContext Context { get; private set; } = new MiningContext();

    }
}
