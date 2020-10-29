using Lizandra.WebMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace Lizandra.WebMVC.Data
{
    public class SalesWebMvcContext : DbContext
    {
        public SalesWebMvcContext (DbContextOptions<SalesWebMvcContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Sellers { get; set; }

        public DbSet<SalesRecord> SalesRecords { get; set; }
    }
}