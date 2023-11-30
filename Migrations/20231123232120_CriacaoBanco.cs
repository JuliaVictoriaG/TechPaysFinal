using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechPays.Migrations
{
    /// <inheritdoc />
    public partial class CriacaoBanco : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Empresas",
                columns: table => new
                {
                    emprid = table.Column<int>(name: "empr_id", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    emprnome = table.Column<string>(name: "empr_nome", type: "nvarchar(max)", nullable: true),
                    emprrazaosocial = table.Column<string>(name: "empr_razao_social", type: "nvarchar(max)", nullable: true),
                    emprcnpj = table.Column<string>(name: "empr_cnpj", type: "nvarchar(max)", nullable: true),
                    emprcnae = table.Column<string>(name: "empr_cnae", type: "nvarchar(max)", nullable: false),
                    emprendereco = table.Column<string>(name: "empr_endereco", type: "nvarchar(max)", nullable: false),
                    emprbairro = table.Column<string>(name: "empr_bairro", type: "nvarchar(max)", nullable: false),
                    emprendnumero = table.Column<int>(name: "empr_end_numero", type: "int", nullable: false),
                    emprtelefone = table.Column<string>(name: "empr_telefone", type: "nvarchar(max)", nullable: false),
                    emprinscmunicipal = table.Column<string>(name: "empr_insc_municipal", type: "nvarchar(max)", nullable: false),
                    emprinscestadual = table.Column<string>(name: "empr_insc_estadual", type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresa", x => x.emprid);
                });

            migrationBuilder.CreateTable(
                name: "Login",
                columns: table => new
                {
                    login = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    senha = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Login", x => x.login);
                });

            migrationBuilder.CreateTable(
                name: "Redefinir_Senha",
                columns: table => new
                {
                    Login = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Redefinir_Senha", x => x.Login);
                });

            migrationBuilder.CreateTable( 
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Login = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Perfil = table.Column<int>(type: "int", nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuario_Sem_Senha",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Login = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Perfil = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario_Sem_Senha", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Funcionarios",
                columns: table => new
                {
                    funcid = table.Column<int>(name: "func_id", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    funcusuario = table.Column<int>(name: "func_usuario", type: "int", nullable: false),
                    funcnome = table.Column<string>(name: "func_nome", type: "nvarchar(max)", nullable: false),
                    funcdepartamento = table.Column<string>(name: "func_departamento", type: "nvarchar(max)", nullable: false),
                    funccargo = table.Column<string>(name: "func_cargo", type: "nvarchar(max)", nullable: false),
                    funccpf = table.Column<string>(name: "func_cpf", type: "nvarchar(max)", nullable: false),
                    funcrg = table.Column<string>(name: "func_rg", type: "nvarchar(max)", nullable: false),
                    funcendereco = table.Column<string>(name: "func_endereco", type: "nvarchar(max)", nullable: false),
                    funcbairro = table.Column<string>(name: "func_bairro", type: "nvarchar(max)", nullable: false),
                    funcendnumero = table.Column<int>(name: "func_end_numero", type: "int", nullable: false),
                    funccelular = table.Column<string>(name: "func_celular", type: "nvarchar(max)", nullable: false),
                    funcestado = table.Column<string>(name: "func_estado", type: "nvarchar(max)", nullable: false),
                    funccidade = table.Column<string>(name: "func_cidade", type: "nvarchar(max)", nullable: false),
                    funccep = table.Column<string>(name: "func_cep", type: "nvarchar(max)", nullable: false),
                    funcemail = table.Column<string>(name: "func_email", type: "nvarchar(max)", nullable: false),
                    funcsalariobruto = table.Column<decimal>(name: "func_salario_bruto", type: "decimal(18,2)", nullable: false),
                    funcsalarioliquido = table.Column<decimal>(name: "func_salario_liquido", type: "decimal(18,2)", nullable: true),
                    funcinss = table.Column<decimal>(name: "func_inss", type: "decimal(18,2)", nullable: true),
                    funcfgts = table.Column<decimal>(name: "func_fgts", type: "decimal(18,2)", nullable: true),
                    funcdtadmissao = table.Column<DateTime>(name: "func_dt_admissao", type: "datetime2", nullable: false),
                    funchoratrab = table.Column<string>(name: "func_hora_trab", type: "nvarchar(max)", nullable: false),
                    funcctps = table.Column<string>(name: "func_ctps", type: "nvarchar(max)", nullable: false),
                    funcvaletransporte = table.Column<float>(name: "func_vale_transporte", type: "real", nullable: true),
                    funcvalealimentacao = table.Column<float>(name: "func_vale_alimentacao", type: "real", nullable: true),
                    UsuarioModelId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcionarios", x => x.funcid);
                    table.ForeignKey(
                        name: "FK_Funcionarios_Usuario_UsuarioModelId",
                        column: x => x.UsuarioModelId,
                        principalTable: "Usuario",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Funcionarios_UsuarioModelId",
                table: "Funcionarios",
                column: "UsuarioModelId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Empresa");

            migrationBuilder.DropTable(
                name: "Funcionarios");

            migrationBuilder.DropTable(
                name: "Login");

            migrationBuilder.DropTable(
                name: "Redefinir_Senha");

            migrationBuilder.DropTable(
                name: "Usuario_Sem_Senha");

            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
