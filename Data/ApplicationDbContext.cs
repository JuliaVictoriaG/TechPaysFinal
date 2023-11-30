using Microsoft.EntityFrameworkCore;
using TechPays.Data.Map;
using TechPays.Models;

namespace TechPays.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<FuncionarioModel> Funcionarios { get; set; }
        public DbSet<EmpresaModel> Empresa { get; set; }
        public DbSet<LoginModel> Login { get; set; }
        public DbSet<RedefinirSenhaModel> Redefinir_Senha{ get; set; }
        public DbSet<UsuarioModel> Usuario { get; set; }
        public DbSet<UsuarioSemSenhaModel> Usuario_Sem_Senha { get; set; }
         public DbSet<FolhaDePagamentoModel> Folha_Pagamento { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FuncionarioMap());
                base.OnModelCreating(modelBuilder);

        }

    }
}
