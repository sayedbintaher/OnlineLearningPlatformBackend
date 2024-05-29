using Microsoft.EntityFrameworkCore;
using OnlineLearningPlatform.Database.Database;
using OnlineLearningPlatform.IRepository.Infrastructure;

namespace OnlineLearningPlatform.Repository.Infrastructure
{
    public abstract class Repository<T> : IGenericRepository<T> where T : class
    {
        ApplicationDbContext _db;
        public DbSet<T> Table
        {
            get
            {
                return _db.Set<T>();
            }
        }
        public Repository(ApplicationDbContext db)
        {
            _db = db;
        }

        public virtual async Task<ICollection<T>> GetAsync()
        {
            return await Table.ToListAsync();
        }

        public bool AddAsync(T Entity)
        {
            Table.AddAsync(Entity);
            return true;
        }

        public bool UpdateAsync(T Entity)
        {
            Table.Update(Entity);
            return true;
        }

        public bool DeleteAsync(T Entity)
        {
            Table.Remove(Entity);
            return true;
        }

        public async Task<T> GetByIdAsync(int id)
        {
            var entity = await Table.FindAsync(id);
            if (entity == null)
                return null;
            return entity;
        }
    }
}
