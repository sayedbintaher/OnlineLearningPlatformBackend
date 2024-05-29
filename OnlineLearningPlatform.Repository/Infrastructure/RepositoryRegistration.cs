using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OnlineLearningPlatform.Database.Database;
using OnlineLearningPlatform.IRepository.Infrastructure;

namespace OnlineLearningPlatform.Repository.Infrastructure
{
    public class RepositoryRegistration : IRepositoryRegistration
    {
        public void AddInfrastructure(IServiceCollection services, string connString)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlServer(connString);
            });
        }
    }
}