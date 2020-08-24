using Secretaria.Domain.Escuela;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Secretaria.Domain.Context.EscuelaConfiguracion
{
    public class SeguimientoConfiguracion : IEntityTypeConfiguration<Seguimiento>
    {
        public void Configure(EntityTypeBuilder<Seguimiento> mb)
        {
            mb.ToTable("Seguimiento");

            mb.HasKey(x => x.IdSeguimiento);

            mb.HasOne(x => x.Alumno)
                .WithMany(x => x.Seguimientos)
                .HasForeignKey(x => new { x.Libro, x.Folio })
                .IsRequired();

            mb.Property(x => x.Libro)
                .HasColumnName("libro")
                .IsRequired();

            mb.Property(x => x.Folio)
                .HasColumnName("folio")
                .IsRequired();

            mb.Property(x => x.IdSeguimiento)
                .ValueGeneratedOnAdd()
                .HasColumnName("idSeguimiento")
                .IsRequired();

            mb.Property(x => x.Observacion)
                .HasColumnName("observacion")
                .HasMaxLength(250)
                .IsRequired();

            mb.Property(x => x.Fecha)
                .HasColumnName("fecha")
                .HasColumnType("Date")
                .IsRequired();
        }
    }
}
