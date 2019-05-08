using System;

namespace MiningManager.Repository
{
    public class BaseRepository : IBaseRepository
    {
        //public BaseRepository(MiningContext ctx)
        //{
        //    Context = ctx ?? throw new ArgumentNullException("Le context est null");
        //}

        public MiningContext Context { get; private set; } = new MiningContext();

    }
}
