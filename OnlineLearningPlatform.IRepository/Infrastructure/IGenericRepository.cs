using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineLearningPlatform.IRepository.Infrastructure
{
    public interface IGenericRepository<T> where T : class
    {
        Task<ICollection<T>> GetAsync();
        Task<T> GetByIdAsync(int id);
        bool AddAsync(T Entity);
        bool UpdateAsync(T Entity);
        bool DeleteAsync(T Entity);
    }
}