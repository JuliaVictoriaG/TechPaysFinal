﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TechPays.Data;

#nullable disable

namespace TechPays.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231125010630_AdicaoFolha")]
    partial class AdicaoFolha
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TechPays.Models.EmpresaModel", b =>
                {
                    b.Property<int>("empr_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("empr_id"));

                    b.Property<string>("empr_bairro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("empr_cnae")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("empr_cnpj")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("empr_end_numero")
                        .HasColumnType("int");

                    b.Property<string>("empr_endereco")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("empr_insc_estadual")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("empr_insc_municipal")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("empr_nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("empr_razao_social")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("empr_telefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("empr_id");

                    b.ToTable("Empresas");
                });

            modelBuilder.Entity("TechPays.Models.FolhaDePagamentoModel", b =>
                {
                    b.Property<int>("fp_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("fp_id"));

                    b.Property<Guid>("fk_funcionario")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("fp_ano")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fp_mes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("fp_salario_liquido")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("fp_id");

                    b.ToTable("Folha_Pagamento");
                });

            modelBuilder.Entity("TechPays.Models.FuncionarioModel", b =>
                {
                    b.Property<int>("func_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("func_id"));

                    b.Property<int?>("UsuarioModelId")
                        .HasColumnType("int");

                    b.Property<string>("func_bairro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("func_cargo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("func_celular")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("func_cep")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("func_cidade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("func_cpf")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("func_ctps")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("func_departamento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("func_dt_admissao")
                        .HasColumnType("datetime2");

                    b.Property<string>("func_email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("func_end_numero")
                        .HasColumnType("int");

                    b.Property<string>("func_endereco")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("func_estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("func_fgts")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("func_hora_trab")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("func_inss")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("func_nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("func_rg")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("func_salario_bruto")
                        .IsRequired()
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("func_salario_liquido")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("func_usuario")
                        .HasColumnType("int");

                    b.Property<float?>("func_vale_alimentacao")
                        .HasColumnType("real");

                    b.Property<float?>("func_vale_transporte")
                        .HasColumnType("real");

                    b.HasKey("func_id");

                    b.HasIndex("UsuarioModelId");

                    b.ToTable("Funcionarios");
                });

            modelBuilder.Entity("TechPays.Models.LoginModel", b =>
                {
                    b.Property<string>("login")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("login");

                    b.ToTable("Login");
                });

            modelBuilder.Entity("TechPays.Models.RedefinirSenhaModel", b =>
                {
                    b.Property<string>("Login")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Login");

                    b.ToTable("Redefinir_Senha");
                });

            modelBuilder.Entity("TechPays.Models.UsuarioModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("DataAtualizacao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Perfil")
                        .HasColumnType("int");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("TechPays.Models.UsuarioSemSenhaModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Perfil")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Usuario_Sem_Senha");
                });

            modelBuilder.Entity("TechPays.Models.FuncionarioModel", b =>
                {
                    b.HasOne("TechPays.Models.UsuarioModel", null)
                        .WithMany("Funcionarios")
                        .HasForeignKey("UsuarioModelId");
                });

            modelBuilder.Entity("TechPays.Models.UsuarioModel", b =>
                {
                    b.Navigation("Funcionarios");
                });
#pragma warning restore 612, 618
        }
    }
}
