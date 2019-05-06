using System.Collections.Generic;
using System.Linq;
using MiningManager.Model;

namespace MiningManager.Repository
{
    public interface ICommunRepository<T> : IBaseRepository
        where T : Commun, new()
    {
        T GetById(int Id);

        IQueryable<T> GetAll();

        T Add(T entity);

        void AddRange(List<T> entities);

        void Update(T entity);

        void Delete(int id);

        void Delete(T entity);

        void Commit();
    }
}
