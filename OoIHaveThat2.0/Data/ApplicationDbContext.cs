using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OoIHaveThat2._0.Models;

namespace OoIHaveThat2._0.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<OoIHaveThat2._0.Models.Response> Response { get; set; } = default!;
    }
}