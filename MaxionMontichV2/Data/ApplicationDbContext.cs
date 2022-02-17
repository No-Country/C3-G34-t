using MaxionMontichV2.Models;
using Microsoft.EntityFrameworkCore;

namespace MaxionMontichV2.Data
{
    public class ApplicationDbContext: DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Rol> Rol { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Planta> Planta { get; set; }
        public DbSet<Elevadores> Elevadores { get; set; }
        public DbSet<TablerosElectricos> Tab_Electricos { get; set; }
        public DbSet<HyM> Herra_Y_Maq { get; set; }
        public DbSet<FormElevadores> Form_Elevadores { get; set; }
        public DbSet<FormHyM> Form_Herra_Y_Maq { get; set; }
        public DbSet<FormTablerosElectricos> Form_Tab_Electricos { get; set; }
        public DbSet<Opciones> Opciones { get; set; }


        
    }
}
