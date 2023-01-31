using MAVS_Projeto_Windows_Forms.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAVS_Projeto_Windows_Forms.Interface
{
    public interface IRepositorioFuncionario
    {
        int ObterTotalDeFuncionarios();

        bool AdicionarFuncionario(Funcionario funcionario);

        void AtualizarFuncionario(Funcionario funcionario);

        void ApagarFuncionario(int funcionarioId);

        Funcionario[] ObterTodosFuncionarios();

        Funcionario[] ObterPorLogin(int login);

        bool AutenticarFuncionario (string login, string password);
    }
}
