using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Secretaria.Domain.DatosPersonales;

namespace Secretaria.Domain.Context.DatosPersonalesConfiguracion
{
    public class NacionalidadConfiguracion : IEntityTypeConfiguration<Nacionalidad>
    {
        public void Configure(EntityTypeBuilder<Nacionalidad> mb)
        {
            mb.ToTable("Nacionalidad");

            mb.HasKey(x => x.Id);

            mb.HasIndex(x => x.Cadena)
                .IsUnique();

            mb.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("idNacionalidad")
                .IsRequired();

            mb.Property(x => x.Cadena)
                .HasColumnName("nacionalidad")
                .HasMaxLength(45)
                .IsRequired();
        }
    }
}
