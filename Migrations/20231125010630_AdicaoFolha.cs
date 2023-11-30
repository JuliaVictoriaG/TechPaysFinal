using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechPays.Migrations
{
    /// <inheritdoc />
    public partial class AdicaoFolha : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Empresa",
                table: "Empresa");

            migrationBuilder.RenameTable(
                name: "Empresa",
                newName: "Empresas");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Empresas",
                table: "Empresas",
                column: "empr_id");

            migrationBuilder.CreateTable(
                name: "Folha_Pagamento",
                columns: table => new
                {
                    fpid = table.Column<int>(name: "fp_id", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fpmes = table.Column<string>(name: "fp_mes", type: "nvarchar(max)", nullable: false),
                    fpano = table.Column<string>(name: "fp_ano", type: "nvarchar(max)", nullable: false),
                    fpsalarioliquido = table.Column<decimal>(name: "fp_salario_liquido", type: "decimal(18,2)", nullable: false),
                    fkfuncionario = table.Column<Guid>(name: "fk_funcionario", type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Folha_Pagamento", x => x.fpid);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Folha_Pagamento");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Empresas",
                table: "Empresas");

            migrationBuilder.RenameTable(
                name: "Empresas",
                newName: "Empresa");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Empresa",
                table: "Empresa",
                column: "empr_id");
        }
    }
}
