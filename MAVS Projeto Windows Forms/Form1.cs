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
            if (username== string.Empty || password == string.Empty)
            {
                MessageBox.Show("Username ou Password não foram preenchidas", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            // cria conexão à base de dados
            SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\cs_ba\Desktop\FDS-MAVS\MAVS Projeto Windows Forms\Database1.mdf"";Integrated Security=True");
            cn.Open();
            
            // Inicio da query
            SqlCommand cmd = new SqlCommand("select * from Funcionarios where username='" + username + "' and password='" + password + "'", cn);
            
            SqlDataReader dr = cmd.ExecuteReader();

            // Se leitura da BD coincidir com tabela executa if
            if (dr.Read())
            {
                dr.Close();
                MessageBox.Show("Login com sucesso ", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                dr.Close();
                MessageBox.Show("No Account found ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}