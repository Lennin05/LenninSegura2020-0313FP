using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LenninSegura2020_0313FP.Migrations
{
    /// <inheritdoc />
    public partial class Lenninsegura20200313sec : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AnoEscolar",
                table: "AnoEscolar",
                newName: "anoEscolar");

            migrationBuilder.AddColumn<int>(
                name: "CursoID",
                table: "Maestros",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NIE",
                table: "Estudiantes",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Estudiantes",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "anoescolarID",
                table: "Cursos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "maestroID",
                table: "Asignaturas",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "anoEscolar",
                table: "AnoEscolar",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldUnicode: false,
                oldMaxLength: 50);

            migrationBuilder.CreateTable(
                name: "Inscripcion",
                columns: table => new
                {
                    IdInscripcion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha_Inscripcion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Fecha_Limite = table.Column<DateTime>(type: "datetime2", nullable: false),
                    cursoID = table.Column<int>(type: "int", nullable: true),
                    estudianteID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inscripcion", x => x.IdInscripcion);
                    table.ForeignKey(
                        name: "FK_Inscripcion_Cursos_cursoID",
                        column: x => x.cursoID,
                        principalTable: "Cursos",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Inscripcion_Estudiantes_estudianteID",
                        column: x => x.estudianteID,
                        principalTable: "Estudiantes",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Maestros_CursoID",
                table: "Maestros",
                column: "CursoID");

            migrationBuilder.CreateIndex(
                name: "IX_Cursos_anoescolarID",
                table: "Cursos",
                column: "anoescolarID");

            migrationBuilder.CreateIndex(
                name: "IX_Asignaturas_maestroID",
                table: "Asignaturas",
                column: "maestroID");

            migrationBuilder.CreateIndex(
                name: "IX_Inscripcion_cursoID",
                table: "Inscripcion",
                column: "cursoID");

            migrationBuilder.CreateIndex(
                name: "IX_Inscripcion_estudianteID",
                table: "Inscripcion",
                column: "estudianteID");

            migrationBuilder.AddForeignKey(
                name: "FK_Asignaturas_Maestros_maestroID",
                table: "Asignaturas",
                column: "maestroID",
                principalTable: "Maestros",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Cursos_AnoEscolar_anoescolarID",
                table: "Cursos",
                column: "anoescolarID",
                principalTable: "AnoEscolar",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Maestros_Cursos_CursoID",
                table: "Maestros",
                column: "CursoID",
                principalTable: "Cursos",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Asignaturas_Maestros_maestroID",
                table: "Asignaturas");

            migrationBuilder.DropForeignKey(
                name: "FK_Cursos_AnoEscolar_anoescolarID",
                table: "Cursos");

            migrationBuilder.DropForeignKey(
                name: "FK_Maestros_Cursos_CursoID",
                table: "Maestros");

            migrationBuilder.DropTable(
                name: "Inscripcion");

            migrationBuilder.DropIndex(
                name: "IX_Maestros_CursoID",
                table: "Maestros");

            migrationBuilder.DropIndex(
                name: "IX_Cursos_anoescolarID",
                table: "Cursos");

            migrationBuilder.DropIndex(
                name: "IX_Asignaturas_maestroID",
                table: "Asignaturas");

            migrationBuilder.DropColumn(
                name: "CursoID",
                table: "Maestros");

            migrationBuilder.DropColumn(
                name: "anoescolarID",
                table: "Cursos");

            migrationBuilder.DropColumn(
                name: "maestroID",
                table: "Asignaturas");

            migrationBuilder.RenameColumn(
                name: "anoEscolar",
                table: "AnoEscolar",
                newName: "AnoEscolar");

            migrationBuilder.AlterColumn<string>(
                name: "NIE",
                table: "Estudiantes",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldUnicode: false,
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Estudiantes",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldUnicode: false,
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AnoEscolar",
                table: "AnoEscolar",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
