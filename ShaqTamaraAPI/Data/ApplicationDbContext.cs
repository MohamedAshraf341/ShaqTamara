using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ShaqTamaraAPI.Data.Models;

namespace ShaqTamaraAPI.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<ApplicationUser>().ToTable("Users");
            builder.Entity<IdentityRole>().ToTable("Roles");
            builder.Entity<IdentityUserRole<string>>().ToTable("UserRoles");
            builder.Entity<IdentityUserClaim<string>>().ToTable("UserClaims");
            builder.Entity<IdentityUserLogin<string>>().ToTable("UserLogins");
            builder.Entity<IdentityRoleClaim<string>>().ToTable("RoleClaims");
            builder.Entity<IdentityUserToken<string>>().ToTable("UserTokens");
            // to delete Column from user
            //builder.Entity<ApplicationUser>().ToTable("Users").Ignore(e => e.Email);
            //builder.Entity<ApplicationUser>().ToTable("Users").Ignore(e => e.NormalizedEmail);
            //builder.Entity<ApplicationUser>().ToTable("Users").Ignore(e => e.UserName);
            //builder.Entity<ApplicationUser>().ToTable("Users").Ignore(e => e.NormalizedUserName);
            //builder.Entity<ApplicationUser>().ToTable("Users").Ignore(e => e.EmailConfirmed);
            //builder.Entity<ApplicationUser>().ToTable("Users").Ignore(e => e.Email);
            //builder.Entity<ApplicationUser>().ToTable("Users").Ignore(e => e.TwoFactorEnabled);
            //builder.Entity<ApplicationUser>().ToTable("Users").Ignore(e => e.LockoutEnabled);
            //builder.Entity<ApplicationUser>().ToTable("Users").Ignore(e => e.LockoutEnd);
            //builder.Entity<ApplicationUser>().ToTable("Users").Ignore(e => e.AccessFailedCount);


        }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Donation> Donations { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Like> Likes { get; set; }
    }
}
