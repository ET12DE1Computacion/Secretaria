using Secretaria.Domain.Faltas;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Secretaria.Domain.Context.FaltasConfiguracion
{
    public class TipoFaltaConfiguracion : IEntityTypeConfiguration<TipoFalta>
    {
        public void Configure(EntityTypeBuilder<TipoFalta> mb)
        {
            mb.ToTable("tipoFalta");

            mb.HasKey(x => x.Id);

            mb.HasIndex(x => x.Cadena)
                .IsUnique();

            mb.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("idTipoFalta");

            mb.Property(x => x.Cadena)
                .HasColumnName("tipoFalta")
                .HasMaxLength(20)
                .IsRequired();
        }
    }
}
