using ApiDotNetCore.Models.Pocos;
using Microsoft.EntityFrameworkCore;

namespace ApiDotNetCore.Contexts
{
    public class ApiContext : DbContext
    {
        public ApiContext(DbContextOptions<ApiContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

        public DbSet<Event> Events { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<EventAttendees> EventAttendees { get; set; }

    }
}
