using Microsoft.EntityFrameworkCore;
using zoo_backend_vs.Models;

namespace zoo_backend_vs.Data  
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<ServiceSpot> serviceSpot { get; set; }

    }
}
