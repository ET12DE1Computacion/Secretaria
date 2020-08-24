using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Secretaria.Domain.DatosPersonales;

namespace Secretaria.Domain.Context.DatosPersonalesConfiguracion
{
    public class PersonaConfiguracion : IEntityTypeConfiguration<Persona>
    {
        public void Configure(EntityTypeBuilder<Persona> mb)
        {
            mb.ToTable("Persona");

            mb.HasKey(x => new { x.NroDocumento, x.IdTipoDocumento });

            mb.Property(x => x.NroDocumento)
                .HasColumnName("nroDocumento")
                .IsRequired();

            mb.Property(x => x.IdTipoDocumento)
              .HasColumnName("idTipoDocumento")
              .IsRequired();

            mb.HasOne(x => x.TipoDocumento)
                .WithMany()
                .HasForeignKey(x => x.IdTipoDocumento)
                .IsRequired();

            mb.Property<byte>("idNacionalidad");

            mb.HasOne(x => x.Nacionalidad)
                .WithMany()
                .HasForeignKey("idNacionalidad")
                .IsRequired();

            mb.Property<int>("idDomicilio");

            mb.HasOne(x => x.Domicilio)
                .WithMany()
                .HasForeignKey("idDomicilio")
                .IsRequired();

            mb.Property(x => x.Nombre)
                .HasColumnName("nombre")
                .HasMaxLength(45)
                .IsRequired();

            mb.Property(x => x.Apellido)
                .HasColumnName("apellido")
                .HasMaxLength(45)
                .IsRequired();

            mb.Property(x => x.Nacimiento)
                .HasColumnName("nacimiento")
                .HasColumnType("Date")
                .IsRequired();

            mb.Property(x => x.Telefono1)
                .HasColumnName("telelfono1");

            mb.Property(x => x.Telefono2)
                .HasColumnName("telefono2");

            mb.Property(x => x.Mail)
                .HasColumnName("mail")
                .HasMaxLength(60);
        }
    }
}
