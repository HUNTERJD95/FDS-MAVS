using System.Net.Mail;
using System.ComponentModel.DataAnnotations;
using MAVS_Projeto_Windows_Forms.Repositorio;

namespace MAVS_Projeto_Windows_Forms.Dominio
{
    // Classe Funcionario
    public class Funcionario
    {
        [Key]
        public int Id { get; set;  }
        public string Nome { get; set; }
        public string NomeUtilizador { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime DataRegisto { get; set;  }

        // verifica em loop dentro do input se cada caracter é uma letra ou se contém um "espaço"
        public static bool ValidarNome(string nome)
        {
            if (string.IsNullOrEmpty(nome)) { return false; }
            return nome.All(c => char.IsLetter(c) || c == ' ');
        }

        // Validação de username (Se for null ou vazia e se tamanho > 3, não aceita)
        public static bool ValidarUsername(string nomeUtilizador)
        {
            return !string.IsNullOrEmpty(nomeUtilizador) && nomeUtilizador.Length > 3;
        }

        // Validação de password (Auto explicativa através das strings)
        public static string? ValidarPassword(string password)
        {
            if (string.IsNullOrEmpty(password)) { return "A password esta vazia!"; }
            if (password.Length < 8 || password.Length > 30) { return "A password tem de ter entre 8 a 30 caracteres!"; }
            if (!password.Any(c => char.IsUpper(c))) { return "A password tem de ter pelo menos 1 maiuscula!"; }
            if (!password.Any(c => char.IsLower(c))) { return "A password tem de ter pelo menos 1 minuscula!"; }
            if (!password.Any(c => char.IsNumber(c))) { return "A password tem de ter pelo menos 1 numero!"; }
            if (!password.Any(c => char.IsSymbol(c) || char.IsPunctuation(c))) { return "A password tem de ter pelo menos 1 simbolo!"; }
            return null;
        }

        // Valida se a label "confirmarPassword" tem o mesmo valor que a label "Password"
        public static bool ValidarConfirmacaoPassword(string password, string confirmacao)
        {
            return password.Equals(confirmacao);
        }

        // Validar email com recurso a método inbutido "MailAdress"
        public static bool ValidarEmail(string email)
        {
            try { 
                var mailAddress = new MailAddress(email);
                return true;
            }
            catch (FormatException) { return false; }
        }
    }
}
