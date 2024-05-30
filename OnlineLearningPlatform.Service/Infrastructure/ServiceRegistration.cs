using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using OnlineLearningPlatform.IRepository.Infrastructure;
using OnlineLearningPlatform.IService.Infrastructure;
using OnlineLearningPlatform.Repository.Infrastructure;

namespace OnlineLearningPlatform.Service.Infrastructure
{
    public class ServiceRegistration : IServiceRegistration
    {
        public static IRepositoryRegistration Registration { get; set; } = new RepositoryRegistration();
        public void AddInfrastructure(IServiceCollection services, string connString)
        {
            Registration.AddInfrastructure(services, connString);
        }
    }
}