using MAVS_Projeto_Windows_Forms.Domain;
using MAVS_Projeto_Windows_Forms.Interface;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAVS_Projeto_Windows_Forms.Repositorio
{
    internal class RepositorioFuncionario : IRepositorioFuncionario 
    {
        public bool AdicionarFuncionario(Funcionario funcionario )
        {
            throw new System.NotImplementedException();
        }

        public void ApagarFuncionario(int funcionarioId)
        {
            throw new NotImplementedException();
        }

        public void AtualizarFuncionario(Funcionario funcionario)
        {
            throw new NotImplementedException();
        }

        public bool AutenticarFuncionario(string login, string password)
        {
            throw new NotImplementedException();
        }

        public Funcionario[] ObterPorLogin(int login)
        {
            throw new NotImplementedException();
        }

        public Funcionario[] ObterTodosFuncionarios()
        {
            throw new NotImplementedException();
        }

        public int ObterTotalDeFuncionarios()
        {
            throw new NotImplementedException();
        }

    }
    
  
    

}
