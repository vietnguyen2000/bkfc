using Microsoft.EntityFrameworkCore;
using bkfc.Models;

namespace bkfc.Data
{
    public class bkfcContext : DbContext
    {
        public bkfcContext(DbContextOptions<bkfcContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<PaymentFood>().HasKey(pf => new { pf.PaymentId, pf.FoodId, });
        }

        public DbSet<Vendor> Vendor { get; set; }
        public DbSet<Food> Food { get; set; }
        public DbSet<Payment> Payment { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<Report> Report { get; set; }
        public DbSet<PaymentFood> PaymentFood { get; set; }
    }
}