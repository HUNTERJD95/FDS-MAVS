using MAVS_Projeto_Windows_Forms.Dominio;

namespace MAVS_Projeto_Windows_Forms.Interface
{
    public interface IRepositorioFuncionario
    {
        IEnumerable<Funcionario> ObterFuncionarios();

        Funcionario? ObterFuncionarioPorId(int id);

        void AdicionarFuncionario(Funcionario funcionario);

        void AtualizarFuncionario(Funcionario funcionario);

        void RemoverFuncionario(int id);

        Funcionario? Login(string nomeUtilizador, string password);

        bool NomeUtilizadorExiste(string nomeUtilizador);
    }
}
