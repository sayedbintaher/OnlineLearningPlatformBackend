using Microsoft.EntityFrameworkCore;

namespace OnlineLearningPlatform.Database.Database
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
    }
}