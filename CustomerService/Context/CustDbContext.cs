using CustomerService.Entity;
using Microsoft.EntityFrameworkCore;

namespace CustomerService.Context
{
    public class CustDbContext : DbContext
    {
        public CustDbContext(DbContextOptions<CustDbContext> context)
      : base(context)
        {

        }
        public DbSet<Customer> Customers { get; set; }
    }
}
