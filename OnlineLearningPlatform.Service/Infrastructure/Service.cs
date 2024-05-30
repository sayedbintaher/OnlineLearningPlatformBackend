using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineLearningPlatform.IRepository.Infrastructure;
using OnlineLearningPlatform.IService.Infrastructure;

namespace OnlineLearningPlatform.Service.Infrastructure
{
    public abstract class Service<T> : IGenericService<T> where T : class
    {
        protected IGenericRepository<T> _repository;
        public Service(IGenericRepository<T> repository)
        {
            _repository = repository;
        }

        public virtual bool AddAsync(T Entity)
        {
            var Success = _repository.AddAsync(Entity);
            if (!Success)
            {
                return false;
            }
            return true;
        }

        public bool DeleteAsync(T Entity)
        {
            var Success = _repository.DeleteAsync(Entity);
            if (!Success)
            {
                return false;
            }
            return true;
        }

        public virtual async Task<ICollection<T>> GetAsync()
        {
            return await _repository.GetAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public bool UpdateAsync(T Entity)
        {
            var Success = _repository.UpdateAsync(Entity);
            if (!Success)
            {
                return false;
            }
            return true;
        }
    }
}