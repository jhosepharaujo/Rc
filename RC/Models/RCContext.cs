using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using RC.Models.Mapping;

namespace RC.Models
{
    public partial class RCContext : DbContext
    {
        static RCContext()
        {
            Database.SetInitializer<RCContext>(null);
        }

        public RCContext()
            : base("Name=RCContext")
        {
        }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Incidente> Incidentes { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CategoriaMap());
            modelBuilder.Configurations.Add(new IncidenteMap());
            modelBuilder.Configurations.Add(new sysdiagramMap());
        }
    }
}
