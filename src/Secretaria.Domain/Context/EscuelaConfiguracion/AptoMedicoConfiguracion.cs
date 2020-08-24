using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Secretaria.Domain.Escuela;

namespace Secretaria.Domain.Context.EscuelaConfiguracion
{
    public class AptoMedicoConfiguracion : IEntityTypeConfiguration<AptoMedico>
    {
        public void Configure(EntityTypeBuilder<AptoMedico> builder)
        {
            builder.ToTable("AptoMedico");

            builder.HasKey(x => new { x.Vencimiento, x.Libro, x.Folio });

            builder.Property(x => x.Vencimiento)
                .HasColumnName("vencimiento")
                .IsRequired();

            builder.HasOne(x => x.Alumno)
                .WithMany(x => x.AptoMedicos)
                .IsRequired();

            builder.Property(x => x.Libro)
               .HasColumnName("libro")
               .IsRequired();

            builder.Property(x => x.Folio)
                .HasColumnName("folio")
                .IsRequired();
        }
    }
}
