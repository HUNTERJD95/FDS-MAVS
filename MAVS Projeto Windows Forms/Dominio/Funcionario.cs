using System.ComponentModel;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MAVS_Projeto_Windows_Forms.Domain
{
    public class Funcionario
    {
        [Key]
        public int Id { get; set;  }
        public string Nome { get; set; }
        public string NomeUtilizador { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime DataRegisto { get; set;  }

/*        public Funcionario() { }

        public Funcionario(string nome, string nomeUtilizador, string password, string email)
        {
            Nome = nome;
            NomeUtilizador = nomeUtilizador;
            Password = password;
            Email = email;
        }*/

       /* public static Funcionario CreateNew(string nome, string username, string password, string email)
        {
            return new Funcionario(nome, username, password, email);
        }*/

        public static bool ValidarNome(string nome)
        {
            Regex regex = new Regex(
                "^(\\b[A-Za-z]*\\b\\s+\\b[A-Za-z]*\\b+\\.[A-Za-z])$",
                RegexOptions.IgnoreCase |
                RegexOptions.CultureInvariant |
                RegexOptions.IgnorePatternWhitespace|
                RegexOptions.Compiled
            );

            return regex.IsMatch(nome);
        }

        public static bool ValidarUsername(string username)
        {
            return !string.IsNullOrEmpty(username) && username.Trim().Length > 3;
        }

        public static bool ValidarPassword(string password)
        {
            // https://regexlib.com/REDetails.aspx?regexp_id=1111
            // at least 1 character
            // at least 1 number
            // at least 1 special character
            // at least 1 uppercase letter
            // at least 1 lowercase letter
            // at least 8 characters in length
            // at most 30 characters in length
            Regex regex = new Regex(
                "^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[@$!%*?&])[A-Za-z\\d@$!%*?&]{8,30}$",
                RegexOptions.IgnoreCase
                | RegexOptions.CultureInvariant
                | RegexOptions.IgnorePatternWhitespace
                | RegexOptions.Compiled
            );

            return regex.IsMatch(password);
        }

        public static bool ValidarConfirmacaoPassword(string password, string confirmacao)
        {
            return password.Equals(confirmacao);
        }

        public static bool ValidarEmail(string email)
        {
            string regex = @"^[^@\s]+@[^@\s]+\.(com|net|org|gov)$";

            return Regex.IsMatch(email, regex, RegexOptions.IgnoreCase);
        }
    }
}
