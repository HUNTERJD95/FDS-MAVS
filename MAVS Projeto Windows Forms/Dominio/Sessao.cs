using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAVS_Projeto_Windows_Forms.Dominio
{
    internal class Sessao
    {
        public static Funcionario? FuncionarioAutenticado { get; set; } // Propriedade estática para permitir controlar quem iniciou sessão
    }
}
