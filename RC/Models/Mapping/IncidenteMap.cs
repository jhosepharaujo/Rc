using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RC.Models.Mapping
{
    public class IncidenteMap : EntityTypeConfiguration<Incidente>
    {
        public IncidenteMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Lat)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Lng)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Descricao)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("Incidente");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Lat).HasColumnName("Lat");
            this.Property(t => t.Lng).HasColumnName("Lng");
            this.Property(t => t.Descricao).HasColumnName("Descricao");
            this.Property(t => t.IdCategoria).HasColumnName("IdCategoria");

            // Relationships
            this.HasRequired(t => t.Categoria)
                .WithMany(t => t.Incidentes)
                .HasForeignKey(d => d.IdCategoria);

        }
    }
}
