using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AccessData.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clinicas",
                columns: table => new
                {
                    ClinicaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Telefono = table.Column<int>(type: "int", nullable: false),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clinicas", x => x.ClinicaId);
                });

            migrationBuilder.CreateTable(
                name: "Especialidades",
                columns: table => new
                {
                    EspecialidadId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Especialidades", x => x.EspecialidadId);
                });

            migrationBuilder.CreateTable(
                name: "Pacientes",
                columns: table => new
                {
                    NroHistoriaClinica = table.Column<int>(type: "int", maxLength: 15, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClinicaId = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Telefono = table.Column<int>(type: "int", nullable: false),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pacientes", x => x.NroHistoriaClinica);
                    table.ForeignKey(
                        name: "FK_Pacientes_Clinicas_ClinicaId",
                        column: x => x.ClinicaId,
                        principalTable: "Clinicas",
                        principalColumn: "ClinicaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Medicos",
                columns: table => new
                {
                    NroMatricula = table.Column<int>(type: "int", maxLength: 15, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EspecialidadId = table.Column<int>(type: "int", nullable: false),
                    ClinicaId = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Telefono = table.Column<int>(type: "int", nullable: false),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medicos", x => x.NroMatricula);
                    table.ForeignKey(
                        name: "FK_Medicos_Clinicas_ClinicaId",
                        column: x => x.ClinicaId,
                        principalTable: "Clinicas",
                        principalColumn: "ClinicaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Medicos_Especialidades_EspecialidadId",
                        column: x => x.EspecialidadId,
                        principalTable: "Especialidades",
                        principalColumn: "EspecialidadId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Consulta",
                columns: table => new
                {
                    ConsultaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Costo = table.Column<int>(type: "int", nullable: false),
                    MedicoId = table.Column<int>(type: "int", nullable: false),
                    PacienteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consulta", x => x.ConsultaId);
                    table.ForeignKey(
                        name: "FK_Consulta_Medicos_MedicoId",
                        column: x => x.MedicoId,
                        principalTable: "Medicos",
                        principalColumn: "NroMatricula",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Consulta_Pacientes_PacienteId",
                        column: x => x.PacienteId,
                        principalTable: "Pacientes",
                        principalColumn: "NroHistoriaClinica",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ConsultasEnConsultorio",
                columns: table => new
                {
                    ConsultaId = table.Column<int>(type: "int", nullable: false),
                    NroConsultorio = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConsultasEnConsultorio", x => x.ConsultaId);
                    table.ForeignKey(
                        name: "FK_ConsultasEnConsultorio_Consulta_ConsultaId",
                        column: x => x.ConsultaId,
                        principalTable: "Consulta",
                        principalColumn: "ConsultaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PracticasMedicas",
                columns: table => new
                {
                    ConsultaId = table.Column<int>(type: "int", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CostoMaterialies = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PracticasMedicas", x => x.ConsultaId);
                    table.ForeignKey(
                        name: "FK_PracticasMedicas_Consulta_ConsultaId",
                        column: x => x.ConsultaId,
                        principalTable: "Consulta",
                        principalColumn: "ConsultaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Clinicas",
                columns: new[] { "ClinicaId", "Mail", "Nombre", "Telefono" },
                values: new object[] { 1, "clinicaInformatica@mail.com", "Clinica Informatica", 42557896 });

            migrationBuilder.InsertData(
                table: "Especialidades",
                columns: new[] { "EspecialidadId", "Descripcion", "Nombre" },
                values: new object[,]
                {
                    { 1, "Descripcion de especialidad 1", "Especialidad 1" },
                    { 2, "Descripcion de especialidad 2", "Especialidad 2" },
                    { 3, "Descripcion de especialidad 3", "Especialidad 3" },
                    { 4, "Descripcion de especialidad 4", "Especialidad 4" },
                    { 5, "Descripcion de especialidad 5", "Especialidad 5" }
                });

            migrationBuilder.InsertData(
                table: "Medicos",
                columns: new[] { "NroMatricula", "Apellido", "ClinicaId", "EspecialidadId", "Mail", "Nombre", "Telefono" },
                values: new object[,]
                {
                    { 1, "Apellido del medico1", 1, 1, "medico1@mail.com", "Medico1", 4256000 },
                    { 2, "Apellido del medico2", 1, 2, "medico2@mail.com", "Medico2", 4256001 },
                    { 3, "Apellido del medico3", 1, 3, "medico3@mail.com", "Medico3", 4256002 },
                    { 4, "Apellido del medico4", 1, 4, "medico4@mail.com", "Medico4", 4256003 },
                    { 5, "Apellido del medico5", 1, 5, "medico5@mail.com", "Medico5", 4256004 }
                });

            migrationBuilder.InsertData(
                table: "Pacientes",
                columns: new[] { "NroHistoriaClinica", "Apellido", "ClinicaId", "Mail", "Nombre", "Telefono" },
                values: new object[,]
                {
                    { 1, "Apellido del paciente1", 1, "paciente1@mail.com", "Paciente1", 4255778 },
                    { 2, "Apellido del paciente2", 1, "paciente2@mail.com", "Paciente2", 4255779 },
                    { 3, "Apellido del paciente3", 1, "paciente3@mail.com", "Paciente3", 4255780 },
                    { 4, "Apellido del paciente4", 1, "paciente4@mail.com", "Paciente4", 4255781 },
                    { 5, "Apellido del paciente5", 1, "paciente5@mail.com", "Paciente5", 4255782 }
                });

            migrationBuilder.InsertData(
                table: "Consulta",
                columns: new[] { "ConsultaId", "Costo", "Fecha", "MedicoId", "PacienteId" },
                values: new object[,]
                {
                    { 1, 500, new DateTime(2022, 3, 30, 0, 22, 9, 304, DateTimeKind.Local).AddTicks(8933), 1, 1 },
                    { 6, 500, new DateTime(2022, 3, 30, 0, 22, 9, 309, DateTimeKind.Local).AddTicks(3537), 1, 1 },
                    { 2, 500, new DateTime(2022, 3, 30, 0, 22, 9, 308, DateTimeKind.Local).AddTicks(3642), 2, 2 },
                    { 7, 500, new DateTime(2022, 3, 30, 0, 22, 9, 309, DateTimeKind.Local).AddTicks(7811), 2, 2 },
                    { 3, 500, new DateTime(2022, 3, 30, 0, 22, 9, 308, DateTimeKind.Local).AddTicks(3781), 3, 3 },
                    { 8, 500, new DateTime(2022, 3, 30, 0, 22, 9, 309, DateTimeKind.Local).AddTicks(7929), 3, 3 },
                    { 4, 500, new DateTime(2022, 3, 30, 0, 22, 9, 308, DateTimeKind.Local).AddTicks(3823), 4, 4 },
                    { 9, 500, new DateTime(2022, 3, 30, 0, 22, 9, 309, DateTimeKind.Local).AddTicks(7969), 4, 4 },
                    { 5, 500, new DateTime(2022, 3, 30, 0, 22, 9, 308, DateTimeKind.Local).AddTicks(3858), 5, 5 },
                    { 10, 500, new DateTime(2022, 3, 30, 0, 22, 9, 309, DateTimeKind.Local).AddTicks(8005), 5, 5 }
                });

            migrationBuilder.InsertData(
                table: "ConsultasEnConsultorio",
                columns: new[] { "ConsultaId", "NroConsultorio" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 3, 3 },
                    { 4, 4 },
                    { 5, 5 }
                });

            migrationBuilder.InsertData(
                table: "PracticasMedicas",
                columns: new[] { "ConsultaId", "CostoMaterialies", "Descripcion" },
                values: new object[,]
                {
                    { 6, 600, "Descripcion de practica medica 6" },
                    { 7, 700, "Descripcion de practica medica 7" },
                    { 8, 800, "Descripcion de practica medica 8" },
                    { 9, 900, "Descripcion de practica medica 9" },
                    { 10, 1000, "Descripcion de practica medica 10" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clinicas_ClinicaId",
                table: "Clinicas",
                column: "ClinicaId");

            migrationBuilder.CreateIndex(
                name: "IX_Consulta_MedicoId",
                table: "Consulta",
                column: "MedicoId");

            migrationBuilder.CreateIndex(
                name: "IX_Consulta_PacienteId",
                table: "Consulta",
                column: "PacienteId");

            migrationBuilder.CreateIndex(
                name: "IX_ConsultasEnConsultorio_ConsultaId",
                table: "ConsultasEnConsultorio",
                column: "ConsultaId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Especialidades_EspecialidadId",
                table: "Especialidades",
                column: "EspecialidadId");

            migrationBuilder.CreateIndex(
                name: "IX_Medicos_ClinicaId",
                table: "Medicos",
                column: "ClinicaId");

            migrationBuilder.CreateIndex(
                name: "IX_Medicos_EspecialidadId",
                table: "Medicos",
                column: "EspecialidadId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pacientes_ClinicaId",
                table: "Pacientes",
                column: "ClinicaId");

            migrationBuilder.CreateIndex(
                name: "IX_PracticasMedicas_ConsultaId",
                table: "PracticasMedicas",
                column: "ConsultaId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ConsultasEnConsultorio");

            migrationBuilder.DropTable(
                name: "PracticasMedicas");

            migrationBuilder.DropTable(
                name: "Consulta");

            migrationBuilder.DropTable(
                name: "Medicos");

            migrationBuilder.DropTable(
                name: "Pacientes");

            migrationBuilder.DropTable(
                name: "Especialidades");

            migrationBuilder.DropTable(
                name: "Clinicas");
        }
    }
}
