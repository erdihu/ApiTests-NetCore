using ApiDotNetCore.Models.Pocos;
using Microsoft.EntityFrameworkCore;

namespace ApiDotNetCore.Contexts
{
    public class ApiContext : DbContext
    {
        public ApiContext(DbContextOptions<ApiContext> options) : base(options)
        {

        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlite("Data Source=api.db");
        //}

        public DbSet<Event> Events { get; set; }

    }
}
