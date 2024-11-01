using Microsoft.EntityFrameworkCore;
using LojaAPI.Models;

namespace LojaAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<LojaAPI.Models.Cliente> Cliente { get; set; } = default!;
        public DbSet<LojaAPI.Models.Roupa> Roupa { get; set; } = default!;
    }


}

