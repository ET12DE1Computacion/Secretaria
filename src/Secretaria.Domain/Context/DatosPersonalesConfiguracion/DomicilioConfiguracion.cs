using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Secretaria.Domain.DatosPersonales;

namespace Secretaria.Domain.Context.DatosPersonalesConfiguracion
{
    public class DomicilioConfiguracion : IEntityTypeConfiguration<Domicilio>
    {
        public void Configure(EntityTypeBuilder<Domicilio> mb)
        {
            mb.ToTable("Domicilio");

            mb.HasKey(x => x.IdDomicilio);

            mb.Property<byte>("idLocalidad");

            mb.HasOne(x => x.Localidad)
              .WithMany()
              .HasForeignKey("idLocalidad")
              .IsRequired();

            mb.Property(x => x.IdDomicilio)
                .ValueGeneratedOnAdd()
                .HasColumnName("idDomicilio");

            mb.Property(x => x.Calle)
                .HasColumnName("calle")
                .HasMaxLength(45)
                .IsRequired();

            mb.Property(x => x.Altura)
                .HasColumnName("altura");

            mb.Property(x => x.Piso)
                .HasColumnName("piso");

            mb.Property(x => x.Departamento)
                .HasColumnName("departamento")
                .HasMaxLength(3);

            mb.Property(x => x.CodigoPostal)
                .HasColumnName("codigoPostal")
                .HasMaxLength(8);

            mb.Property(x => x.observacionDomicilio)
                .HasColumnName("observacionDomicilio")
                .HasMaxLength(60);
        }
    }
}