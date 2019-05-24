using MiningManager.Model;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;

namespace MiningManager.Repository
{
    public class CommunRepository<T> : BaseRepository, ICommunRepository<T>
        where T : Commun, new()
    {
        #region Proprietes 

        protected DbSet<T> DbSet => Context.Set<T>();

        #endregion

        public T GetById(int id)
        {
            return DbSet.Find(id);
        }

        public virtual IQueryable<T> GetAll()
        {
            return DbSet;
        }

        public T Add(T entity)
        {
            DbEntityEntry dbEntityEntry = Context.Entry(entity);
            if (dbEntityEntry.State != EntityState.Detached)
            {
                dbEntityEntry.State = EntityState.Added;
            }

            DbSet.Add(entity);
            Commit();

            return entity;
        }

        public void AddRange(List<T> entities)
        {
            DbSet.AddRange(entities);

            Commit();
        }

        public void Update(T entity)
        {
            DbEntityEntry dbEntityEntry = Context.Entry(entity);

            if (dbEntityEntry.State == EntityState.Detached)
            {
                T item = DbSet.SingleOrDefault(x => x.Id == entity.Id);
                Context.Entry(item).State = EntityState.Detached;
            }

            dbEntityEntry.State = EntityState.Modified;

            Commit();
        }

        public void Delete(int id)
        {
            T entity = GetById(id);
            if (entity == null) return; // not found; assume already deleted.
            Delete(entity);
        }

        public void Delete(T entity)
        {
            DbEntityEntry dbEntityEntry = Context.Entry(entity);
            if (dbEntityEntry.State != EntityState.Deleted)
            {
                dbEntityEntry.State = EntityState.Deleted;
            }
            else
            {
                DbSet.Attach(entity);
                DbSet.Remove(entity);
            }

            Commit();
        }

        public void Commit()
        {
            Context.SaveChanges();
        }
    }
}
