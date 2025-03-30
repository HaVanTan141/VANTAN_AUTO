using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using VANTAN_AUTO.Models;

namespace VANTAN_AUTO.Data
{
    public class VANTAN_AUTOContext : IdentityDbContext<IdentityUser>
    {
        public VANTAN_AUTOContext(DbContextOptions<VANTAN_AUTOContext> options)
            : base(options)
        {
        }

        public DbSet<Car> Cars { get; set; }
        public new DbSet<ApplicationUser> Users { get; set; } // Add 'new' keyword

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); // Ensure Identity is configured

           modelBuilder.Entity<Car>(entity =>
{
    entity.Property(e => e.Price)
          .HasColumnType("decimal(18,2)"); // Specify the SQL Server column type
});

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Fullname)
                      .IsRequired();
                entity.Property(e => e.Numberphone)
                      .IsRequired();
            });
        }
    }
}
