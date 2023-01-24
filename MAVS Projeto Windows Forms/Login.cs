using System.Data.SqlClient;
using System.Data.Sql;

namespace MAVS_Projeto_Windows_Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameBox.Text;
            string password = passwordBox.Text;
           
            // caso não haja input
            if (username == string.Empty || password == string.Empty)
            {
                MessageBox.Show("Username ou Password não foram preenchidas", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // envia a query para o database manager
            string sqlQuery = "select * from Funcionarios where username='" + username + "' and password=HASHBYTES('SHA2_512', '" + password + "')";
            SqlDataReader dr  = DatabaseManager.Instance.Query(sqlQuery);
            
            // Se leitura da BD coincidir com tabela executa if
            if (dr.Read())
            {
                dr.Close();
                // MessageBox.Show("Login com sucesso ", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.None);
                
                // Apos login com sucesso envia para form principal (menu)
                this.Hide();
                Menu menu = new Menu();
                menu.Show();
            }
            else
            {
                dr.Close();
                MessageBox.Show("Username ou Password incorretos! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {
            setPassword();
        }

        private void passwordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            setPassword();
        }
        
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

        private void loginButton_KeyDown(object sender, KeyEventArgs e)
        {

        }

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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}