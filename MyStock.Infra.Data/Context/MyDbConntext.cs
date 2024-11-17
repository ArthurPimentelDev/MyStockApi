using Microsoft.EntityFrameworkCore;
using MyStock.Domain.Models;

namespace MyStock.Infra.Data.Context
{
    public class MyDbConntext : DbContext
    {
        public MyDbConntext(DbContextOptions<MyDbConntext> options) : base(options) { }

        public DbSet<Companies> Companies { get; set; }
        public DbSet<Address> Addresses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>()
                .HasOne<Companies>()
                .WithOne()          
                .HasForeignKey<Address>(a => a.CompanyId); 

            base.OnModelCreating(modelBuilder);
        }
    }
}
