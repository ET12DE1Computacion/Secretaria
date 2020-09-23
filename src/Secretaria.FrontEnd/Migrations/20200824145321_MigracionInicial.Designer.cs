﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Secretaria.Domain;

namespace Secretaria.FrontEnd.Migrations
{
    [DbContext(typeof(SecretariaDbContext))]
    [Migration("20200824145321_MigracionInicial")]
    partial class MigracionInicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Secretaria.Domain.DatosPersonales.Domicilio", b =>
                {
                    b.Property<int>("IdDomicilio")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("idDomicilio")
                        .HasColumnType("int");

                    b.Property<int?>("Altura")
                        .HasColumnName("altura")
                        .HasColumnType("int");

                    b.Property<string>("Calle")
                        .IsRequired()
                        .HasColumnName("calle")
                        .HasColumnType("varchar(45) CHARACTER SET utf8mb4")
                        .HasMaxLength(45);

                    b.Property<string>("CodigoPostal")
                        .HasColumnName("codigoPostal")
                        .HasColumnType("varchar(8) CHARACTER SET utf8mb4")
                        .HasMaxLength(8);

                    b.Property<string>("Departamento")
                        .HasColumnName("departamento")
                        .HasColumnType("varchar(3) CHARACTER SET utf8mb4")
                        .HasMaxLength(3);

                    b.Property<byte?>("Piso")
                        .HasColumnName("piso")
                        .HasColumnType("tinyint unsigned");

                    b.Property<byte>("idLocalidad")
                        .HasColumnType("tinyint unsigned");

                    b.Property<string>("observacionDomicilio")
                        .HasColumnName("observacionDomicilio")
                        .HasColumnType("varchar(60) CHARACTER SET utf8mb4")
                        .HasMaxLength(60);

                    b.HasKey("IdDomicilio");

                    b.HasIndex("idLocalidad");

                    b.ToTable("Domicilio");
                });

            modelBuilder.Entity("Secretaria.Domain.DatosPersonales.Localidad", b =>
                {
                    b.Property<byte>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("idLocalidad")
                        .HasColumnType("tinyint unsigned");

                    b.Property<string>("Cadena")
                        .IsRequired()
                        .HasColumnName("localidad")
                        .HasColumnType("varchar(45) CHARACTER SET utf8mb4")
                        .HasMaxLength(45);

                    b.HasKey("Id");

                    b.HasIndex("Cadena")
                        .IsUnique();

                    b.ToTable("Localidad");
                });

            modelBuilder.Entity("Secretaria.Domain.DatosPersonales.Nacionalidad", b =>
                {
                    b.Property<byte>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("idNacionalidad")
                        .HasColumnType("tinyint unsigned");

                    b.Property<string>("Cadena")
                        .IsRequired()
                        .HasColumnName("nacionalidad")
                        .HasColumnType("varchar(45) CHARACTER SET utf8mb4")
                        .HasMaxLength(45);

                    b.HasKey("Id");

                    b.HasIndex("Cadena")
                        .IsUnique();

                    b.ToTable("Nacionalidad");
                });

            modelBuilder.Entity("Secretaria.Domain.DatosPersonales.Persona", b =>
                {
                    b.Property<int>("NroDocumento")
                        .HasColumnName("nroDocumento")
                        .HasColumnType("int");

                    b.Property<byte>("IdTipoDocumento")
                        .HasColumnName("idTipoDocumento")
                        .HasColumnType("tinyint unsigned");

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnName("apellido")
                        .HasColumnType("varchar(45) CHARACTER SET utf8mb4")
                        .HasMaxLength(45);

                    b.Property<string>("Mail")
                        .HasColumnName("mail")
                        .HasColumnType("varchar(60) CHARACTER SET utf8mb4")
                        .HasMaxLength(60);

                    b.Property<DateTime>("Nacimiento")
                        .HasColumnName("nacimiento")
                        .HasColumnType("Date");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnName("nombre")
                        .HasColumnType("varchar(45) CHARACTER SET utf8mb4")
                        .HasMaxLength(45);

                    b.Property<long?>("Telefono1")
                        .HasColumnName("telelfono1")
                        .HasColumnType("bigint");

                    b.Property<long?>("Telefono2")
                        .HasColumnName("telefono2")
                        .HasColumnType("bigint");

                    b.Property<int>("idDomicilio")
                        .HasColumnType("int");

                    b.Property<byte>("idNacionalidad")
                        .HasColumnType("tinyint unsigned");

                    b.HasKey("NroDocumento", "IdTipoDocumento");

                    b.HasIndex("IdTipoDocumento");

                    b.HasIndex("idDomicilio");

                    b.HasIndex("idNacionalidad");

                    b.HasIndex("NroDocumento", "IdTipoDocumento")
                        .IsUnique();

                    b.ToTable("Persona");
                });

            modelBuilder.Entity("Secretaria.Domain.DatosPersonales.TipoDocumento", b =>
                {
                    b.Property<byte>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("idTipoDocumento")
                        .HasColumnType("tinyint unsigned");

                    b.Property<string>("Cadena")
                        .IsRequired()
                        .HasColumnName("tipoDocumento")
                        .HasColumnType("varchar(45) CHARACTER SET utf8mb4")
                        .HasMaxLength(45);

                    b.HasKey("Id");

                    b.HasIndex("Cadena")
                        .IsUnique();

                    b.ToTable("TipoDocumento");
                });

            modelBuilder.Entity("Secretaria.Domain.Escuela.Alumno", b =>
                {
                    b.Property<short>("Libro")
                        .HasColumnName("libro")
                        .HasColumnType("smallint");

                    b.Property<byte>("Folio")
                        .HasColumnName("folio")
                        .HasColumnType("tinyint unsigned");

                    b.Property<byte>("IdTipoDocumento")
                        .HasColumnName("idTipoDocumento")
                        .HasColumnType("tinyint unsigned");

                    b.Property<int>("NroDocumento")
                        .HasColumnName("nroDocumento")
                        .HasColumnType("int");

                    b.Property<int?>("idCursoActual")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("Libro", "Folio");

                    b.HasIndex("idCursoActual");

                    b.HasIndex("Libro", "Folio")
                        .IsUnique();

                    b.HasIndex("NroDocumento", "IdTipoDocumento");

                    b.ToTable("Alumno");
                });

            modelBuilder.Entity("Secretaria.Domain.Escuela.AptoMedico", b =>
                {
                    b.Property<DateTime>("Vencimiento")
                        .HasColumnName("vencimiento")
                        .HasColumnType("datetime(6)");

                    b.Property<short>("Libro")
                        .HasColumnName("libro")
                        .HasColumnType("smallint");

                    b.Property<byte>("Folio")
                        .HasColumnName("folio")
                        .HasColumnType("tinyint unsigned");

                    b.HasKey("Vencimiento", "Libro", "Folio");

                    b.HasIndex("Libro", "Folio");

                    b.ToTable("AptoMedico");
                });

            modelBuilder.Entity("Secretaria.Domain.Escuela.Cursada", b =>
                {
                    b.Property<DateTime>("Inscripcion")
                        .HasColumnName("inscripcion")
                        .HasColumnType("datetime(6)");

                    b.Property<short>("Libro")
                        .HasColumnName("libro")
                        .HasColumnType("smallint");

                    b.Property<byte>("Folio")
                        .HasColumnName("folio")
                        .HasColumnType("tinyint unsigned");

                    b.Property<short>("CicloLectivo")
                        .HasColumnName("cicloLectivo")
                        .HasColumnType("smallint");

                    b.Property<int?>("idCurso")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("Inscripcion", "Libro", "Folio");

                    b.HasIndex("idCurso");

                    b.HasIndex("Libro", "Folio");

                    b.ToTable("Cursada");
                });

            modelBuilder.Entity("Secretaria.Domain.Escuela.Curso", b =>
                {
                    b.Property<int>("IdCurso")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("idCurso")
                        .HasColumnType("int");

                    b.Property<byte>("Anio")
                        .HasColumnName("anio")
                        .HasColumnType("tinyint unsigned");

                    b.Property<byte>("Division")
                        .HasColumnName("division")
                        .HasColumnType("tinyint unsigned");

                    b.HasKey("IdCurso");

                    b.ToTable("Curso");
                });

            modelBuilder.Entity("Secretaria.Domain.Escuela.Seguimiento", b =>
                {
                    b.Property<short>("Libro")
                        .HasColumnName("libro")
                        .HasColumnType("smallint");

                    b.Property<byte>("Folio")
                        .HasColumnName("folio")
                        .HasColumnType("tinyint unsigned");

                    b.Property<DateTime>("Fecha")
                        .HasColumnName("fecha")
                        .HasColumnType("Date");

                    b.Property<string>("Observacion")
                        .IsRequired()
                        .HasColumnName("observacion")
                        .HasColumnType("varchar(250) CHARACTER SET utf8mb4")
                        .HasMaxLength(250);

                    b.HasKey("Libro", "Folio", "Fecha");

                    b.ToTable("Seguimiento");
                });

            modelBuilder.Entity("Secretaria.Domain.Faltas.AsistenciaCurso", b =>
                {
                    b.Property<int>("IdAsistenciaCurso")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("idAsistenciaCurso")
                        .HasColumnType("int");

                    b.Property<DateTime>("Fecha")
                        .HasColumnName("fecha")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("idCurso")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<byte?>("idTipoFalta")
                        .IsRequired()
                        .HasColumnType("tinyint unsigned");

                    b.HasKey("IdAsistenciaCurso");

                    b.HasIndex("idCurso");

                    b.HasIndex("idTipoFalta");

                    b.ToTable("AsisienciaCurso");
                });

            modelBuilder.Entity("Secretaria.Domain.Faltas.Falta", b =>
                {
                    b.Property<short>("Libro")
                        .HasColumnName("libro")
                        .HasColumnType("smallint");

                    b.Property<byte>("Folio")
                        .HasColumnName("folio")
                        .HasColumnType("tinyint unsigned");

                    b.Property<DateTime>("Fecha")
                        .HasColumnName("fecha")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("Justificada")
                        .HasColumnName("justificada")
                        .HasColumnType("tinyint(1)");

                    b.Property<float>("Valor")
                        .HasColumnName("valor")
                        .HasColumnType("float");

                    b.Property<int?>("idCurso")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<byte?>("idTipoAusencia")
                        .IsRequired()
                        .HasColumnType("tinyint unsigned");

                    b.Property<byte?>("idTipoFalta")
                        .IsRequired()
                        .HasColumnType("tinyint unsigned");

                    b.HasKey("Libro", "Folio", "Fecha");

                    b.HasIndex("idCurso");

                    b.HasIndex("idTipoAusencia");

                    b.HasIndex("idTipoFalta");

                    b.ToTable("Falta");
                });

            modelBuilder.Entity("Secretaria.Domain.Faltas.TipoAusencia", b =>
                {
                    b.Property<byte>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("idTipoAusencia")
                        .HasColumnType("tinyint unsigned");

                    b.Property<string>("Cadena")
                        .IsRequired()
                        .HasColumnName("tipoAusencia")
                        .HasColumnType("varchar(30) CHARACTER SET utf8mb4")
                        .HasMaxLength(30);

                    b.Property<float>("Valor")
                        .HasColumnName("valor")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("Cadena")
                        .IsUnique();

                    b.ToTable("TipoAusencia");
                });

            modelBuilder.Entity("Secretaria.Domain.Faltas.TipoFalta", b =>
                {
                    b.Property<byte>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("idTipoFalta")
                        .HasColumnType("tinyint unsigned");

                    b.Property<string>("Cadena")
                        .IsRequired()
                        .HasColumnName("tipoFalta")
                        .HasColumnType("varchar(20) CHARACTER SET utf8mb4")
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.HasIndex("Cadena")
                        .IsUnique();

                    b.ToTable("tipoFalta");
                });

            modelBuilder.Entity("Secretaria.Domain.DatosPersonales.Domicilio", b =>
                {
                    b.HasOne("Secretaria.Domain.DatosPersonales.Localidad", "Localidad")
                        .WithMany()
                        .HasForeignKey("idLocalidad")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Secretaria.Domain.DatosPersonales.Persona", b =>
                {
                    b.HasOne("Secretaria.Domain.DatosPersonales.TipoDocumento", "TipoDocumento")
                        .WithMany()
                        .HasForeignKey("IdTipoDocumento")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Secretaria.Domain.DatosPersonales.Domicilio", "Domicilio")
                        .WithMany()
                        .HasForeignKey("idDomicilio")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Secretaria.Domain.DatosPersonales.Nacionalidad", "Nacionalidad")
                        .WithMany()
                        .HasForeignKey("idNacionalidad")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Secretaria.Domain.Escuela.Alumno", b =>
                {
                    b.HasOne("Secretaria.Domain.Escuela.Curso", "CursoActual")
                        .WithMany("Alumnos")
                        .HasForeignKey("idCursoActual")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Secretaria.Domain.DatosPersonales.Persona", "Persona")
                        .WithMany("Alumnos")
                        .HasForeignKey("NroDocumento", "IdTipoDocumento")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Secretaria.Domain.Escuela.AptoMedico", b =>
                {
                    b.HasOne("Secretaria.Domain.Escuela.Alumno", "Alumno")
                        .WithMany("AptoMedicos")
                        .HasForeignKey("Libro", "Folio")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Secretaria.Domain.Escuela.Cursada", b =>
                {
                    b.HasOne("Secretaria.Domain.Escuela.Curso", "Curso")
                        .WithMany()
                        .HasForeignKey("idCurso")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Secretaria.Domain.Escuela.Alumno", "Alumno")
                        .WithMany("Cursadas")
                        .HasForeignKey("Libro", "Folio")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Secretaria.Domain.Escuela.Seguimiento", b =>
                {
                    b.HasOne("Secretaria.Domain.Escuela.Alumno", "Alumno")
                        .WithMany("Seguimientos")
                        .HasForeignKey("Libro", "Folio")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Secretaria.Domain.Faltas.AsistenciaCurso", b =>
                {
                    b.HasOne("Secretaria.Domain.Escuela.Curso", "Curso")
                        .WithMany("AsistenciaCurso")
                        .HasForeignKey("idCurso")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Secretaria.Domain.Faltas.TipoFalta", "TipoFalta")
                        .WithMany("AsistenciaCurso")
                        .HasForeignKey("idTipoFalta")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Secretaria.Domain.Faltas.Falta", b =>
                {
                    b.HasOne("Secretaria.Domain.Escuela.Curso", "Curso")
                        .WithMany("Faltas")
                        .HasForeignKey("idCurso")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Secretaria.Domain.Faltas.TipoAusencia", "TipoAusencia")
                        .WithMany("Faltas")
                        .HasForeignKey("idTipoAusencia")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Secretaria.Domain.Faltas.TipoFalta", "TipoFalta")
                        .WithMany("Faltas")
                        .HasForeignKey("idTipoFalta")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Secretaria.Domain.Escuela.Alumno", "Alumno")
                        .WithMany("Faltas")
                        .HasForeignKey("Libro", "Folio")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
