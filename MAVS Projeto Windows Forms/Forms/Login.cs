using System.Data.SqlClient;
using System.Data.Sql;
using MAVS_Projeto_Windows_Forms.Dominio;
using MAVS_Projeto_Windows_Forms.Repositorio;

namespace MAVS_Projeto_Windows_Forms
{
    public partial class Login : Form
    {
        private readonly RepositorioFuncionario _repositorioFuncionario;

        public Login()
        {
            InitializeComponent();

            // Abre conexão com SQL server
            _repositorioFuncionario = new RepositorioFuncionario(new MAVSContext());
        }


        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameBox.Text.Trim();
            string password = passwordBox.Text.Trim();
           
            // caso não haja input
            if (username == string.Empty || password == string.Empty)
            {
                MessageBox.Show("Username ou Password não foram preenchidas", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // envia a query para o database manager
            Funcionario? user = _repositorioFuncionario.Login(username, password);

            // Se leitura da BD coincidir com tabela executa if
            if (user != null)
            {
                // MessageBox.Show("Login com sucesso ", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.None);
                
                // Apos login com sucesso envia para form principal (menu)
                Sessao.FuncionarioAutenticado = user;
                this.Hide();
                Menu menu = new Menu();
                menu.Show();
                MessageBox.Show("Bem vindo " + user.Nome + "!");
                
            }
            else
            {
                MessageBox.Show("Username ou Password incorretos! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Função setPasswordBox1 (Para a escrita aparecer com "*"), aplica-se à label password deste menu Login
        private void passwordBox_TextChanged(object sender, EventArgs e)
        {
            setPassword();
        }

        private void passwordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            setPassword();
        }
        
        // Se clicarem na passwordCheckBox, possibilita mostrar ou ocultar a password escrita
        private void setPassword()
        {
            if (passwordCheckBox.Checked)
            {
                passwordBox.PasswordChar = '\0';
            }
            else
            {
                passwordBox.PasswordChar = '*';
            }
        }

        // Ao clicar "Enter" no teclado permite avançar
        private void passwordBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginButton.PerformClick();
            }
        }

        private void usernameBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginButton.PerformClick();
            }
        }

        // Ao clicar em Novo Registo envia para o form Registo
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registo registo = new Registo();
            registo.Show();
        }
    }
}