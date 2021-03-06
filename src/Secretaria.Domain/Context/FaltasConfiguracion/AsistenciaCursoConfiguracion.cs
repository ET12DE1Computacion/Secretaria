﻿using Secretaria.Domain.Faltas;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Secretaria.Domain.Context.FaltasConfiguracion
{
    public class AsistenciaCursoConfiguracion : IEntityTypeConfiguration<AsistenciaCurso>
    {
        public void Configure(EntityTypeBuilder<AsistenciaCurso> mb)
        {
            //Configurar tabla
            mb.ToTable("AsisienciaCurso");

            //Configurar primary key
            mb.HasKey(a => a.IdAsistenciaCurso);

            mb.Property(a => a.IdAsistenciaCurso)
                .ValueGeneratedOnAdd()
                .HasColumnName("idAsistenciaCurso")
                .IsRequired();

            //configurar foreign key
            mb.HasOne(a => a.Curso)
                .WithMany(x => x.AsistenciaCurso)
                .HasForeignKey("idCurso")
                .IsRequired();

            mb.HasOne(a => a.TipoFalta)
                .WithMany(x => x.AsistenciaCurso)
                .HasForeignKey("idTipoFalta")
                .IsRequired();

            //configurar otras propiedades
            mb.Property(a => a.Fecha)
                .HasColumnName("fecha")
                .IsRequired();
        }
    }
}
