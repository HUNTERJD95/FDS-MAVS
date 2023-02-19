using MAVS_Projeto_Windows_Forms.Dominio;
using MAVS_Projeto_Windows_Forms.Interface;

namespace MAVS_Projeto_Windows_Forms.Repositorio
{
    internal class RepositorioFuncionario : IRepositorioFuncionario
    {
        private readonly MAVSContext _context;

        public RepositorioFuncionario(MAVSContext context)
        { 
            _context = context;
        }

        // Adiciona funcionário com password hashing
        public void AdicionarFuncionario(Funcionario funcionario)
        {
            funcionario.Password = BCrypt.Net.BCrypt.HashPassword(funcionario.Password);
            funcionario.DataRegisto = DateTime.Now; // Antes de adicionar funcionário modifica password e data
            _context.Funcionarios.Add(funcionario); // Adiciona o funcionário
            _context.SaveChanges(); // Grava alterações
        }

        public void AtualizarFuncionario(Funcionario funcionario)
        {
            Funcionario? existingFuncionario = ObterFuncionarioPorId(funcionario.Id); // Verifica se funcionário existe
            if (existingFuncionario != null)
            {
                if (funcionario.Password != existingFuncionario.Password) // Compara Hash antiga à Hash actual
                {
                    funcionario.Password = BCrypt.Net.BCrypt.HashPassword(funcionario.Password);
                }
                _context.Entry(existingFuncionario).CurrentValues.SetValues(funcionario); // Altera os valores
                _context.SaveChanges();
            }
        }

        public Funcionario? Login(string nomeUtilizador, string password)
        {
            Funcionario? funcionario = _context.Funcionarios.FirstOrDefault(f => f.NomeUtilizador == nomeUtilizador); // Percorre BD e encontra o primeiro valor correspondente
            if (funcionario == null || !BCrypt.Net.BCrypt.Verify(password, funcionario.Password)) // SE funcionário existir ou senha estiver incorreta devolve null
            {
                return null;
            }
            return funcionario;
        }

        // Procura funcionário por ID
        public Funcionario? ObterFuncionarioPorId(int id)
        {
            return _context.Funcionarios.Find(id);
        }

        // Lista os funcionários existentes
        public IEnumerable<Funcionario> ObterFuncionarios()
        {
            return _context.Funcionarios.ToList();
        }

        // Obtem funcionário por ID, se for null, remove esse funcionário e grava alterações
        public void RemoverFuncionario(int id)
        {
            Funcionario? funcionario = ObterFuncionarioPorId(id);
            if (funcionario != null)
            {
                _context.Funcionarios.Remove(funcionario);
                _context.SaveChanges();
            }
        }

        // Função para verificar se utilizador tem sessão ativa
        public bool NomeUtilizadorExiste(string nomeUtilizador)
        {
            if (Sessao.FuncionarioAutenticado != null)
            {
                return _context.Funcionarios.Any(f => f.NomeUtilizador == nomeUtilizador && Sessao.FuncionarioAutenticado.NomeUtilizador != nomeUtilizador);
            }
            else
            {
                return _context.Funcionarios.Any(f => f.NomeUtilizador == nomeUtilizador);
            }
        }
    }
}
