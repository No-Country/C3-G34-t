using MaxionMontichV2.Models;
using Microsoft.EntityFrameworkCore;

namespace MaxionMontichV2.Data
{
    public class ApplicationDbContext: DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Usuario> Usuario { get; set; }
    }
}
