using Secretaria.Domain.Escuela;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Secretaria.Domain.Context.EscuelaConfiguracion
{
    public class AlumnoConfiguracion : IEntityTypeConfiguration<Alumno>
    {
        public void Configure(EntityTypeBuilder<Alumno> mb)
        {
            mb.ToTable("Alumno");

            mb.HasKey(x => new { x.Libro, x.Folio });

            mb.Property(x => x.Libro)
                .HasColumnName("libro")
                .IsRequired();

            mb.Property(x => x.Folio)
                .HasColumnName("folio")
                .IsRequired();

            mb.HasOne(x => x.Persona)
                .WithMany(x => x.Alumnos)
                .HasForeignKey(x => new { x.NroDocumento, x.IdTipoDocumento } )
                .IsRequired();          

            mb.HasOne(x => x.CursoActual)
                .WithMany(x => x.Alumnos)
                .HasForeignKey("idCursoActual")
                .IsRequired();

            mb.Property(x => x.NroDocumento)
              .HasColumnName("nroDocumento")
              .IsRequired();

            mb.Property(x => x.IdTipoDocumento)
              .HasColumnName("idTipoDocumento")
              .IsRequired();
        }
    }
}
