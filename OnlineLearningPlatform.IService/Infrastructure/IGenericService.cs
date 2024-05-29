using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineLearningPlatform.IService.Infrastructure
{
    public interface IGenericService<T> where T : class
    {
        bool AddAsync(T Entity);
        bool UpdateAsync(T Entity);
        bool DeleteAsync(T Entity);
        Task<ICollection<T>> GetAsync();
        Task<T> GetByIdAsync(int id);
    }
}