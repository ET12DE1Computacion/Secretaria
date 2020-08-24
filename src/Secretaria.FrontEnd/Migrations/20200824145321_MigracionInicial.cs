using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Secretaria.FrontEnd.Migrations
{
    public partial class MigracionInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Curso",
                columns: table => new
                {
                    idCurso = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    division = table.Column<byte>(nullable: false),
                    anio = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Curso", x => x.idCurso);
                });

            migrationBuilder.CreateTable(
                name: "Localidad",
                columns: table => new
                {
                    idLocalidad = table.Column<byte>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    localidad = table.Column<string>(maxLength: 45, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Localidad", x => x.idLocalidad);
                });

            migrationBuilder.CreateTable(
                name: "Nacionalidad",
                columns: table => new
                {
                    idNacionalidad = table.Column<byte>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nacionalidad = table.Column<string>(maxLength: 45, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nacionalidad", x => x.idNacionalidad);
                });

            migrationBuilder.CreateTable(
                name: "TipoAusencia",
                columns: table => new
                {
                    idTipoAusencia = table.Column<byte>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    tipoAusencia = table.Column<string>(maxLength: 30, nullable: false),
                    valor = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoAusencia", x => x.idTipoAusencia);
                });

            migrationBuilder.CreateTable(
                name: "TipoDocumento",
                columns: table => new
                {
                    idTipoDocumento = table.Column<byte>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    tipoDocumento = table.Column<string>(maxLength: 45, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoDocumento", x => x.idTipoDocumento);
                });

            migrationBuilder.CreateTable(
                name: "tipoFalta",
                columns: table => new
                {
                    idTipoFalta = table.Column<byte>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    tipoFalta = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tipoFalta", x => x.idTipoFalta);
                });

            migrationBuilder.CreateTable(
                name: "Domicilio",
                columns: table => new
                {
                    idDomicilio = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    idLocalidad = table.Column<byte>(nullable: false),
                    calle = table.Column<string>(maxLength: 45, nullable: false),
                    altura = table.Column<int>(nullable: true),
                    piso = table.Column<byte>(nullable: true),
                    departamento = table.Column<string>(maxLength: 3, nullable: true),
                    codigoPostal = table.Column<string>(maxLength: 8, nullable: true),
                    observacionDomicilio = table.Column<string>(maxLength: 60, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Domicilio", x => x.idDomicilio);
                    table.ForeignKey(
                        name: "FK_Domicilio_Localidad_idLocalidad",
                        column: x => x.idLocalidad,
                        principalTable: "Localidad",
                        principalColumn: "idLocalidad",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AsisienciaCurso",
                columns: table => new
                {
                    idAsistenciaCurso = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    fecha = table.Column<DateTime>(nullable: false),
                    idCurso = table.Column<int>(nullable: false),
                    idTipoFalta = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AsisienciaCurso", x => x.idAsistenciaCurso);
                    table.ForeignKey(
                        name: "FK_AsisienciaCurso_Curso_idCurso",
                        column: x => x.idCurso,
                        principalTable: "Curso",
                        principalColumn: "idCurso",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AsisienciaCurso_tipoFalta_idTipoFalta",
                        column: x => x.idTipoFalta,
                        principalTable: "tipoFalta",
                        principalColumn: "idTipoFalta",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Persona",
                columns: table => new
                {
                    nroDocumento = table.Column<int>(nullable: false),
                    idTipoDocumento = table.Column<byte>(nullable: false),
                    nombre = table.Column<string>(maxLength: 45, nullable: false),
                    apellido = table.Column<string>(maxLength: 45, nullable: false),
                    idDomicilio = table.Column<int>(nullable: false),
                    mail = table.Column<string>(maxLength: 60, nullable: true),
                    idNacionalidad = table.Column<byte>(nullable: false),
                    nacimiento = table.Column<DateTime>(type: "Date", nullable: false),
                    telelfono1 = table.Column<long>(nullable: true),
                    telefono2 = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persona", x => new { x.nroDocumento, x.idTipoDocumento });
                    table.ForeignKey(
                        name: "FK_Persona_TipoDocumento_idTipoDocumento",
                        column: x => x.idTipoDocumento,
                        principalTable: "TipoDocumento",
                        principalColumn: "idTipoDocumento",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Persona_Domicilio_idDomicilio",
                        column: x => x.idDomicilio,
                        principalTable: "Domicilio",
                        principalColumn: "idDomicilio",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Persona_Nacionalidad_idNacionalidad",
                        column: x => x.idNacionalidad,
                        principalTable: "Nacionalidad",
                        principalColumn: "idNacionalidad",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Alumno",
                columns: table => new
                {
                    libro = table.Column<short>(nullable: false),
                    folio = table.Column<byte>(nullable: false),
                    idCursoActual = table.Column<int>(nullable: false),
                    nroDocumento = table.Column<int>(nullable: false),
                    idTipoDocumento = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alumno", x => new { x.libro, x.folio });
                    table.ForeignKey(
                        name: "FK_Alumno_Curso_idCursoActual",
                        column: x => x.idCursoActual,
                        principalTable: "Curso",
                        principalColumn: "idCurso",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Alumno_Persona_nroDocumento_idTipoDocumento",
                        columns: x => new { x.nroDocumento, x.idTipoDocumento },
                        principalTable: "Persona",
                        principalColumns: new[] { "nroDocumento", "idTipoDocumento" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AptoMedico",
                columns: table => new
                {
                    libro = table.Column<short>(nullable: false),
                    folio = table.Column<byte>(nullable: false),
                    vencimiento = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AptoMedico", x => new { x.vencimiento, x.libro, x.folio });
                    table.ForeignKey(
                        name: "FK_AptoMedico_Alumno_libro_folio",
                        columns: x => new { x.libro, x.folio },
                        principalTable: "Alumno",
                        principalColumns: new[] { "libro", "folio" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cursada",
                columns: table => new
                {
                    libro = table.Column<short>(nullable: false),
                    folio = table.Column<byte>(nullable: false),
                    inscripcion = table.Column<DateTime>(nullable: false),
                    idCurso = table.Column<int>(nullable: false),
                    cicloLectivo = table.Column<short>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cursada", x => new { x.inscripcion, x.libro, x.folio });
                    table.ForeignKey(
                        name: "FK_Cursada_Curso_idCurso",
                        column: x => x.idCurso,
                        principalTable: "Curso",
                        principalColumn: "idCurso",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cursada_Alumno_libro_folio",
                        columns: x => new { x.libro, x.folio },
                        principalTable: "Alumno",
                        principalColumns: new[] { "libro", "folio" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Falta",
                columns: table => new
                {
                    libro = table.Column<short>(nullable: false),
                    folio = table.Column<byte>(nullable: false),
                    fecha = table.Column<DateTime>(nullable: false),
                    idTipoFalta = table.Column<byte>(nullable: false),
                    idTipoAusencia = table.Column<byte>(nullable: false),
                    idCurso = table.Column<int>(nullable: false),
                    valor = table.Column<float>(nullable: false),
                    justificada = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Falta", x => new { x.libro, x.folio, x.fecha });
                    table.ForeignKey(
                        name: "FK_Falta_Curso_idCurso",
                        column: x => x.idCurso,
                        principalTable: "Curso",
                        principalColumn: "idCurso",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Falta_TipoAusencia_idTipoAusencia",
                        column: x => x.idTipoAusencia,
                        principalTable: "TipoAusencia",
                        principalColumn: "idTipoAusencia",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Falta_tipoFalta_idTipoFalta",
                        column: x => x.idTipoFalta,
                        principalTable: "tipoFalta",
                        principalColumn: "idTipoFalta",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Falta_Alumno_libro_folio",
                        columns: x => new { x.libro, x.folio },
                        principalTable: "Alumno",
                        principalColumns: new[] { "libro", "folio" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Seguimiento",
                columns: table => new
                {
                    libro = table.Column<short>(nullable: false),
                    folio = table.Column<byte>(nullable: false),
                    fecha = table.Column<DateTime>(type: "Date", nullable: false),
                    observacion = table.Column<string>(maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seguimiento", x => new { x.libro, x.folio, x.fecha });
                    table.ForeignKey(
                        name: "FK_Seguimiento_Alumno_libro_folio",
                        columns: x => new { x.libro, x.folio },
                        principalTable: "Alumno",
                        principalColumns: new[] { "libro", "folio" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Alumno_idCursoActual",
                table: "Alumno",
                column: "idCursoActual");

            migrationBuilder.CreateIndex(
                name: "IX_Alumno_libro_folio",
                table: "Alumno",
                columns: new[] { "libro", "folio" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Alumno_nroDocumento_idTipoDocumento",
                table: "Alumno",
                columns: new[] { "nroDocumento", "idTipoDocumento" });

            migrationBuilder.CreateIndex(
                name: "IX_AptoMedico_libro_folio",
                table: "AptoMedico",
                columns: new[] { "libro", "folio" });

            migrationBuilder.CreateIndex(
                name: "IX_AsisienciaCurso_idCurso",
                table: "AsisienciaCurso",
                column: "idCurso");

            migrationBuilder.CreateIndex(
                name: "IX_AsisienciaCurso_idTipoFalta",
                table: "AsisienciaCurso",
                column: "idTipoFalta");

            migrationBuilder.CreateIndex(
                name: "IX_Cursada_idCurso",
                table: "Cursada",
                column: "idCurso");

            migrationBuilder.CreateIndex(
                name: "IX_Cursada_libro_folio",
                table: "Cursada",
                columns: new[] { "libro", "folio" });

            migrationBuilder.CreateIndex(
                name: "IX_Domicilio_idLocalidad",
                table: "Domicilio",
                column: "idLocalidad");

            migrationBuilder.CreateIndex(
                name: "IX_Falta_idCurso",
                table: "Falta",
                column: "idCurso");

            migrationBuilder.CreateIndex(
                name: "IX_Falta_idTipoAusencia",
                table: "Falta",
                column: "idTipoAusencia");

            migrationBuilder.CreateIndex(
                name: "IX_Falta_idTipoFalta",
                table: "Falta",
                column: "idTipoFalta");

            migrationBuilder.CreateIndex(
                name: "IX_Localidad_localidad",
                table: "Localidad",
                column: "localidad",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Nacionalidad_nacionalidad",
                table: "Nacionalidad",
                column: "nacionalidad",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Persona_idTipoDocumento",
                table: "Persona",
                column: "idTipoDocumento");

            migrationBuilder.CreateIndex(
                name: "IX_Persona_idDomicilio",
                table: "Persona",
                column: "idDomicilio");

            migrationBuilder.CreateIndex(
                name: "IX_Persona_idNacionalidad",
                table: "Persona",
                column: "idNacionalidad");

            migrationBuilder.CreateIndex(
                name: "IX_Persona_nroDocumento_idTipoDocumento",
                table: "Persona",
                columns: new[] { "nroDocumento", "idTipoDocumento" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TipoAusencia_tipoAusencia",
                table: "TipoAusencia",
                column: "tipoAusencia",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TipoDocumento_tipoDocumento",
                table: "TipoDocumento",
                column: "tipoDocumento",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tipoFalta_tipoFalta",
                table: "tipoFalta",
                column: "tipoFalta",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AptoMedico");

            migrationBuilder.DropTable(
                name: "AsisienciaCurso");

            migrationBuilder.DropTable(
                name: "Cursada");

            migrationBuilder.DropTable(
                name: "Falta");

            migrationBuilder.DropTable(
                name: "Seguimiento");

            migrationBuilder.DropTable(
                name: "TipoAusencia");

            migrationBuilder.DropTable(
                name: "tipoFalta");

            migrationBuilder.DropTable(
                name: "Alumno");

            migrationBuilder.DropTable(
                name: "Curso");

            migrationBuilder.DropTable(
                name: "Persona");

            migrationBuilder.DropTable(
                name: "TipoDocumento");

            migrationBuilder.DropTable(
                name: "Domicilio");

            migrationBuilder.DropTable(
                name: "Nacionalidad");

            migrationBuilder.DropTable(
                name: "Localidad");
        }
    }
}
