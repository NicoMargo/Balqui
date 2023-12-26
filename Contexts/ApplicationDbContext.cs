using Microsoft.EntityFrameworkCore;

namespace Balqui.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<PaymentType> PaymentTypes { get; set; }
    }
}