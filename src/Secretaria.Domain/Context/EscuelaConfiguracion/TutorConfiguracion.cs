﻿using Secretaria.Domain.Escuela;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Secretaria.Domain.Context.EscuelaConfiguracion
{
    public class TutorConfiguracion : IEntityTypeConfiguration<Tutor>
    {
        public void Configure(EntityTypeBuilder<Tutor> mb)
        {
            //string fkPersona = "idPersona";
            //string fkAlumno = "legajo";
            //mb.ToTable("tutor");

            //mb.HasKey(c => c.Id);

            ////mb.HasOne(t => t.Alumno)
            ////    .WithMany(a => a.Tutores)
            ////    .HasForeignKey(fkAlumno)
            ////    .IsRequired();

            //mb.HasOne(t => t.Persona)
            //    .WithMany()
            //    .HasForeignKey(fkPersona)
            //    .IsRequired();

            //mb.HasOne(t => t.TipoTutor)
            //    .WithMany()
            //    .HasForeignKey("idTipoTutor")
            //    .IsRequired();
        }
    }
}
