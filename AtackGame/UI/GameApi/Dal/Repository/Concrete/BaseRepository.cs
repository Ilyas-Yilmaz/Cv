using Dal.PostGre;
using Dal.Repository.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Repository.Concrete
{
    public class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        internal Context _context;

        internal DbSet<TEntity> _dbSet;

        public BaseRepository(Context context)
        {
            this._context = context;
            this._dbSet = context.Set<TEntity>();
        }

        public void Add(TEntity entity)
        {
            _dbSet.Add(entity);
        }

        public void Delete(TEntity entity)
        {
            _dbSet.Remove(entity);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _dbSet.ToList();
        }

        public TEntity GetByID(int? id)
        {
            return _dbSet.Find(id);
        }

        public void Update(TEntity entity)
        {
            _dbSet.Update(entity);
        }
    }
}
