using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace OnlineLearningPlatform.IRepository.Infrastructure
{
    public interface IRepositoryRegistration
    {
        void AddInfrastructure(IServiceCollection services, string connString);
    }
}