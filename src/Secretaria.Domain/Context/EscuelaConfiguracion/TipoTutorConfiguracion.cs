﻿using Secretaria.Domain.Escuela;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Secretaria.Domain.Context.EscuelaConfiguracion
{
    public class TipoTutorConfiguracion : IEntityTypeConfiguration<TipoTutor>
    {
        public void Configure(EntityTypeBuilder<TipoTutor> mb)
        {
            //mb.ToTable("tipoTutor");

            //mb.HasKey(t => t.Id);
            //mb.HasIndex(t => t.Cadena).IsUnique();

            //mb.Property(t => t.Id)
            //    .HasColumnName("idTipoTutor");

            //mb.Property(t => t.Cadena)
            //    .HasColumnName("tipoTutor")
            //    .HasMaxLength(45);
        }
    }
}
