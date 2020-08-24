using Secretaria.Domain.Faltas;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Secretaria.Domain.Context.FaltasConfiguracion
{
    public class TipoAusenciaConfiguracion : IEntityTypeConfiguration<TipoAusencia>
    {
        public void Configure(EntityTypeBuilder<TipoAusencia> mb)
        {
            mb.ToTable("TipoAusencia");

            mb.HasKey(x => x.Id);

            mb.HasIndex(x => x.Cadena)
                .IsUnique();

            mb.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("idTipoAusencia")
                .IsRequired();

            mb.Property(x => x.Cadena)
                .HasColumnName("tipoAusencia")
                .HasMaxLength(30)
                .IsRequired();

            mb.Property(x => x.Valor)
                .HasColumnName("valor")
                .IsRequired();
        }
    }
}
