using Microsoft.EntityFrameworkCore;

namespace AntTableSample.Portal.DataContext
{
    public class PropertyDbContext : DbContext
    {
        public PropertyDbContext(DbContextOptions<PropertyDbContext> options): base(options)
        {
        }

        public DbSet<Property> Properties { get; set; }
    }
}