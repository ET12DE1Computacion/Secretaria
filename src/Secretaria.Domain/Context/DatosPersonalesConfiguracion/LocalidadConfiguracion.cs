using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Secretaria.Domain.DatosPersonales;

namespace Secretaria.Domain.Context.DatosPersonalesConfiguracion
{
    public class LocalidadConfiguracion : IEntityTypeConfiguration<Localidad>
    {
        public void Configure(EntityTypeBuilder<Localidad> mb)
        {
            mb.ToTable("Localidad");

            mb.HasKey(x => x.Id);

            mb.HasIndex(x => x.Cadena)
                .IsUnique();

            mb.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("idLocalidad")
                .IsRequired();

            mb.Property(x => x.Cadena)
                .HasColumnName("localidad")
                .HasMaxLength(45)
                .IsRequired();                
        }
    }
}