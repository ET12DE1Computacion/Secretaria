using Secretaria.Domain.Escuela;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Secretaria.Domain.Context.EscuelaConfiguracion
{
    public class CursadaConfiguracion : IEntityTypeConfiguration<Cursada>
    {
        public void Configure(EntityTypeBuilder<Cursada> mb)
        {
            mb.ToTable("Cursada");

            mb.HasKey(x => x.IdCursada);

            mb.HasOne(x => x.Alumno)
                .WithMany(x => x.Cursadas)
                .HasForeignKey(x => new { x.Libro, x.Folio })
                .IsRequired();

            mb.HasOne(x => x.Curso)
                .WithMany()
                .HasForeignKey("idCurso")
                .IsRequired();

            mb.Property(x => x.Inscripcion)
                .HasColumnName("inscripcion")
                .IsRequired();

            mb.Property(c => c.CicloLectivo)
                .HasColumnName("cicloLectivo")
                .IsRequired();

            mb.Property(x => x.Libro)
               .HasColumnName("libro")
               .IsRequired();

            mb.Property(x => x.Folio)
                .HasColumnName("folio")
                .IsRequired();
        }
    }
}
