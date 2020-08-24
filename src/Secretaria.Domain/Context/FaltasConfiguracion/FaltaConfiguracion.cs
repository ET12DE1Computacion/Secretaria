using Secretaria.Domain.Faltas;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Secretaria.Domain.Escuela;

namespace Secretaria.Domain.Context.FaltasConfiguracion
{
    public class FaltaConfiguracion : IEntityTypeConfiguration<Falta>
    {
        public void Configure(EntityTypeBuilder<Falta> mb)
        {
            //tabla
            mb.ToTable("Falta");

            //primary key
            mb.HasKey(x => new { x.Libro, x.Folio, x.Fecha });

            //foreign key
            mb.HasOne(x => x.Alumno)
               .WithMany(x => x.Faltas)
               .HasForeignKey(x => new { x.Libro, x.Folio })
               .IsRequired();

            mb.HasOne(x => x.TipoFalta)
                .WithMany(x => x.Faltas)
                .HasForeignKey("idTipoFalta")
                .IsRequired();

            mb.HasOne(x => x.TipoAusencia)
                .WithMany(x => x.Faltas)
                .HasForeignKey("idTipoAusencia")
                .IsRequired();

            mb.HasOne(x => x.Cursada)
                .WithMany(x => x.Faltas)
                .HasForeignKey("idCursada")
                .IsRequired();

            //propiedades
            mb.Property(x => x.Libro)
                .HasColumnName("libro")
                .IsRequired();

            mb.Property(x => x.Folio)
                .HasColumnName("folio")
                .IsRequired();

            mb.Property(x => x.Fecha)
                .HasColumnName("fecha")
                .IsRequired();

            mb.Property(x => x.Valor)
                .HasColumnName("valor")
                .IsRequired();

            mb.Property(x => x.Justificada)
                .HasColumnName("justificada")
                .IsRequired();
        }
    }
}
