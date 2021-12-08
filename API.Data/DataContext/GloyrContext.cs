using API.Data.DbModels;
using Microsoft.EntityFrameworkCore;

namespace API.Data.DataContext
{

    public class GloyrContext : DbContext
    {
        public GloyrContext(DbContextOptions options): base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
    }
}
