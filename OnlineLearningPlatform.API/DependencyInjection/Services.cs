using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineLearningPlatform.IService.Infrastructure;
using OnlineLearningPlatform.Service.Infrastructure;

namespace OnlineLearningPlatform.API.DependencyInjection
{
    public static class Services
    {
        public static IServiceRegistration Service { get; set; } = new ServiceRegistration();
        public static void RegisterDependencies(IServiceCollection services, string connString)
        {
            Service.AddInfrastructure(services, connString: connString);
        }

    }
}