using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Secretaria.Domain.DatosPersonales;

namespace Secretaria.Domain.Context.DatosPersonalesConfiguracion
{
    public class TipoDocumentoConfiguracion : IEntityTypeConfiguration<TipoDocumento>
    {
        public void Configure(EntityTypeBuilder<TipoDocumento> mb)
        {
            mb.ToTable("TipoDocumento");

            mb.HasKey(x => x.Id);

            mb.HasIndex(x => x.Cadena)
                .IsUnique();

            mb.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("idTipoDocumento")
                .IsRequired();

            mb.Property(x => x.Cadena)
                .HasColumnName("tipoDocumento")
                .HasMaxLength(45)
                .IsRequired();
        }
    }
}
