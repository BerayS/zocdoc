using Microsoft.EntityFrameworkCore;
using AspNetCoreCookieAuthentication.Data;

namespace AspNetCoreCookieAuthentication.Data {
    public class ApplicationDbContext : DbContext {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<AppointmentSlot> Appointments { get; set; }
        public DbSet<User> Users {get;set;}
    }
}
