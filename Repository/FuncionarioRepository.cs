using TechPays.Data;
using TechPays.Models;

namespace TechPays.Repository
{
    public class FuncionarioRepository : IFuncionarioRepository
    {
        private readonly ApplicationDbContext _db;

        public FuncionarioRepository(ApplicationDbContext db)
        {
            this._db = db;
        }

        public FuncionarioModel BuscarPorID(int id)
        {
            return _db.Funcionarios.FirstOrDefault(x => x.func_id == id);
        }

        public List<FuncionarioModel> BuscarTodos(int usuarioId)
        {
            return _db.Funcionarios.Where(x => x.func_usuario == usuarioId).ToList();
        }

        public FuncionarioModel Adicionar(FuncionarioModel funcionario)
        {
            _db.Funcionarios.Add(funcionario);
            _db.SaveChanges();
            return funcionario;
        }

        public FuncionarioModel Atualizar(FuncionarioModel funcionario)
        {
            FuncionarioModel funcionarioDB = BuscarPorID(funcionario.func_id);

            if (funcionarioDB == null) throw new Exception("Houve um erro na atualização do contato!");

            funcionarioDB.func_nome = funcionario.func_nome;
            funcionarioDB.func_email = funcionario.func_email;
            funcionarioDB.func_celular= funcionario.func_celular;

            _db.Funcionarios.Update(funcionarioDB);
            _db.SaveChanges();

            return funcionarioDB;
        }

        public bool Apagar(int id)
        {
            FuncionarioModel funcionarioDB = BuscarPorID(id);

            if (funcionarioDB == null) throw new Exception("Houve um erro na deleção do contato!");

            _db.Funcionarios.Remove(funcionarioDB);
            _db.SaveChanges();

            return true;
        }
    }
}
