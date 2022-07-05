using Microsoft.EntityFrameworkCore;
using CarRentalWeb.Pages.Model;

namespace CarRentalWeb.Pages.Data
{
    public class ApplicationDbContext:DbContext
    {
        public DbSet<Category> Category { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {

        }
    }
}
