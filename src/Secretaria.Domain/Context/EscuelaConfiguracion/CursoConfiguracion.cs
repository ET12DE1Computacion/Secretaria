using Secretaria.Domain.Escuela;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Secretaria.Domain.Context.EscuelaConfiguracion
{
    public class CursoConfiguracion : IEntityTypeConfiguration<Curso>
    {
        public void Configure(EntityTypeBuilder<Curso> mb)
        {
            mb.ToTable("Curso");

            mb.HasKey(x => x.IdCurso);

            mb.Property(x => x.IdCurso)
                .ValueGeneratedOnAdd()
                .HasColumnName("idCurso")
                .IsRequired();

            mb.Property(x => x.Anio)
                .HasColumnName("anio")
                .IsRequired();

            mb.Property(x => x.Division)
                .HasColumnName("division")
                .IsRequired();
        }
    }
}
