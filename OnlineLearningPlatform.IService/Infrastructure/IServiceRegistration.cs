using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace OnlineLearningPlatform.IService.Infrastructure
{
    public interface IServiceRegistration
    {
        void AddInfrastructure(IServiceCollection services);
    }
}