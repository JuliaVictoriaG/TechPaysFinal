using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechPays.Migrations
{
    /// <inheritdoc />
    public partial class CriandoVinculo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Funcionarios_Usuario_UsuarioModelId",
                table: "Funcionarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Login",
                table: "Login");

            migrationBuilder.DropIndex(
                name: "IX_Funcionarios_UsuarioModelId",
                table: "Funcionarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Empresas",
                table: "Empresas");

            migrationBuilder.DropColumn(
                name: "UsuarioModelId",
                table: "Funcionarios");

            migrationBuilder.RenameTable(
                name: "Empresas",
                newName: "Empresa");

            migrationBuilder.AlterColumn<string>(
                name: "login",
                table: "Login",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "func_cpf",
                table: "Login",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Funcionariofunc_id",
                table: "Login",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<double>(
                name: "func_salario_liquido",
                table: "Funcionarios",
                type: "float",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "func_salario_bruto",
                table: "Funcionarios",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AddColumn<int>(
                name: "usuarioId",
                table: "Funcionarios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<double>(
                name: "fp_salario_liquido",
                table: "Folha_Pagamento",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<string>(
                name: "empr_telefone",
                table: "Empresa",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "empr_insc_municipal",
                table: "Empresa",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "empr_insc_estadual",
                table: "Empresa",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "empr_endereco",
                table: "Empresa",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "empr_cnae",
                table: "Empresa",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Login",
                table: "Login",
                column: "func_cpf");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Empresa",
                table: "Empresa",
                column: "empr_id");

            migrationBuilder.CreateIndex(
                name: "IX_Login_Funcionariofunc_id",
                table: "Login",
                column: "Funcionariofunc_id");

            migrationBuilder.CreateIndex(
                name: "IX_Funcionarios_usuarioId",
                table: "Funcionarios",
                column: "usuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Funcionarios_Usuario_usuarioId",
                table: "Funcionarios",
                column: "usuarioId",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Login_Funcionarios_Funcionariofunc_id",
                table: "Login",
                column: "Funcionariofunc_id",
                principalTable: "Funcionarios",
                principalColumn: "func_id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Funcionarios_Usuario_usuarioId",
                table: "Funcionarios");

            migrationBuilder.DropForeignKey(
                name: "FK_Login_Funcionarios_Funcionariofunc_id",
                table: "Login");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Login",
                table: "Login");

            migrationBuilder.DropIndex(
                name: "IX_Login_Funcionariofunc_id",
                table: "Login");

            migrationBuilder.DropIndex(
                name: "IX_Funcionarios_usuarioId",
                table: "Funcionarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Empresa",
                table: "Empresa");

            migrationBuilder.DropColumn(
                name: "func_cpf",
                table: "Login");

            migrationBuilder.DropColumn(
                name: "Funcionariofunc_id",
                table: "Login");

            migrationBuilder.DropColumn(
                name: "usuarioId",
                table: "Funcionarios");

            migrationBuilder.RenameTable(
                name: "Empresa",
                newName: "Empresas");

            migrationBuilder.AlterColumn<string>(
                name: "login",
                table: "Login",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "func_salario_liquido",
                table: "Funcionarios",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "func_salario_bruto",
                table: "Funcionarios",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AddColumn<int>(
                name: "UsuarioModelId",
                table: "Funcionarios",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "fp_salario_liquido",
                table: "Folha_Pagamento",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<string>(
                name: "empr_telefone",
                table: "Empresas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "empr_insc_municipal",
                table: "Empresas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "empr_insc_estadual",
                table: "Empresas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "empr_endereco",
                table: "Empresas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "empr_cnae",
                table: "Empresas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Login",
                table: "Login",
                column: "login");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Empresas",
                table: "Empresas",
                column: "empr_id");

            migrationBuilder.CreateIndex(
                name: "IX_Funcionarios_UsuarioModelId",
                table: "Funcionarios",
                column: "UsuarioModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Funcionarios_Usuario_UsuarioModelId",
                table: "Funcionarios",
                column: "UsuarioModelId",
                principalTable: "Usuario",
                principalColumn: "Id");
        }
    }
}
