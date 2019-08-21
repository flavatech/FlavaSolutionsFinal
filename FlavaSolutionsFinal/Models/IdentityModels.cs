using System;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace FlavaSolutionsFinal.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        // Here we add a byte to Save the user Profile Pictuer  
        public byte[] UserPhoto { get; set; }
        public DateTime? LastLogin { get; set; }
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
         
        public DbSet<Activity> activities { get; set; }
        public DbSet<Period> periods { get; set; }
        public DbSet<Plan> plans { get; set; }
        public DbSet<Trainer> trainers { get; set; }
        public DbSet<Transaction> transactions { get; set; }
        public DbSet<MemberAccount> memberAccounts { get; set; }

       public ApplicationDbContext()
          : base("DefaultConnection", throwIfV1Schema: false)

        {
         }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ApplicationUser>().ToTable("Users");
            modelBuilder.Entity<IdentityUserClaim>().ToTable("UserClaim");
            modelBuilder.Entity<IdentityUserRole>().ToTable("UserRoles");
            modelBuilder.Entity<IdentityUserLogin>().ToTable("UserLogins");
            modelBuilder.Entity<IdentityRole>().ToTable("Roles");
        }

        public System.Data.Entity.DbSet<FlavaSolutionsFinal.Models.PaymentType> PaymentTypes { get; set; }
    }
}