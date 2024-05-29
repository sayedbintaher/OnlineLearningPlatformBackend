using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineLearningPlatform.IRepository.Infrastructure
{
    public interface IUnitOfWork
    {
        Task<int> CommitAsync();
    }
}