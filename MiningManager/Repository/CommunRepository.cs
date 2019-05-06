using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace MiningManager.Repository
{
    public class CommunRepository<T> : BaseRepository, ICommunRepository<T>
        where T : class, new()
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
            AttachEntity(entity, EntityState.Added);
            DbSet.Add(entity);
            Commit();

            return entity;
        }

        public void AddRange(List<T> entities)
        {
            List<T> list = new List<T>();
            foreach (T entity in entities)
            {
                DbSet.Add(AttachEntity(entity, EntityState.Added));
            }

            Commit();
        }

        public void Update(T entity)
        {
            AttachEntity(entity, EntityState.Modified);

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
            DbEntityEntry dbEntityEntry = Instance.Entry(entity);
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

        private T AttachEntity(T entity, EntityState state)
        {
            DbEntityEntry dbEntityEntry = Instance.Entry(entity);
            if (dbEntityEntry.State != EntityState.Detached)
            {
                dbEntityEntry.State = state;
            }

            return entity;
        }

        public void Commit()
        {
            Instance.SaveChanges();
        }
    }
}
