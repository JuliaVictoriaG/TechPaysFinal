using TechPays.Models;

namespace TechPays.Repository
{
    public interface IFuncionarioRepository
    {
        List<FuncionarioModel> BuscarTodos(int usuarioId);
        FuncionarioModel BuscarPorID(int id);
        FuncionarioModel Adicionar(FuncionarioModel funcionario);
        FuncionarioModel Atualizar(FuncionarioModel funcionario);
        bool Apagar(int id);
    }
}
