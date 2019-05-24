using MiningManager.Model;
using System.Linq;

namespace MiningManager.Repository
{
    public class InWorldRepository<T> : CommunRepository<T>, IInWorldRepository<T>
        where T : InWorld, new()
    {
        public Modele GetModele()
        {
            return DbSet.First().Modele;
        }
    }
}
