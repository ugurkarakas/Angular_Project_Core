using API.Core.DbModels;
using Microsoft.EntityFrameworkCore;

namespace API.Insfrastructure.DataContext
{

    public class GloyrContext : DbContext
    {
        public GloyrContext(DbContextOptions options): base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
    }
}
