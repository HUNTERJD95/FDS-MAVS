using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using MAVS_Projeto_Windows_Forms.Dominio;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using MAVS_Projeto_Windows_Forms.Repositorio;

namespace MAVS_Projeto_Windows_Forms
{
    public partial class Registo : Form
    {
        private readonly RepositorioFuncionario _repositorioFuncionario;
        private bool isEdit = false;
        private Funcionario? currentFuncionario;

        public Registo()
        {
            InitializeComponent();

            _repositorioFuncionario = new RepositorioFuncionario(new MAVSContext());
        }

        public Registo(int funcionarioId)
        {
            InitializeComponent();

            // Serve para preencher o form com os dados do funcionário para depois editar
            isEdit = true;

            _repositorioFuncionario = new RepositorioFuncionario(new MAVSContext());

            Funcionario? funcionario = _repositorioFuncionario.ObterFuncionarioPorId(funcionarioId);
            if (funcionario != null)
            {
                currentFuncionario = funcionario;
                
                textBoxNome.Text = funcionario.Nome;
                textBoxUsername.Text = funcionario.NomeUtilizador;
                textBoxEmail.Text = funcionario.Email;
            }
        }

        // Função setPasswordBox1 (Para a escrita aparecer com "*"), aplica-se à label password
        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            setPasswordBox1();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            setPasswordBox1();
        }

        // Função setPasswordBox2 (Para a escrita aparecer com "*"), aplica-se à label confirmar password
        private void textBoxConfirmarPassword_TextChanged(object sender, EventArgs e)
        {
            setPasswordBox2();
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            setPasswordBox2();
        }


       // Foram feitas 2 funções para conseguir ver a password na label 'password' e na label 'confirmar password', sendo passwordbox1 a primeira label (password) e setpasswordbox2 a segunda (confirmar)
        private void setPasswordBox1()
        {
            if (checkBoxPasswordRegisto1.Checked)
            {
                textBoxPassword.PasswordChar = '\0';
            }
            else
            {
                textBoxPassword.PasswordChar = '*';
            }
        }

        private void setPasswordBox2()
        {
            if (checkBoxPasswordRegisto2.Checked)
            {
                textBoxConfirmarPassword.PasswordChar = '\0';
            }
            else
            {
                textBoxConfirmarPassword.PasswordChar = '*';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Ao clicar registar, enviar os valores para BD com as confirmações
            string nome = textBoxNome.Text.Trim();
            string nomeUtilizador = textBoxUsername.Text.Trim();
            string password = textBoxPassword.Text.Trim();
            string confirmacao = textBoxConfirmarPassword.Text.Trim();
            string email = textBoxEmail.Text.Trim();

            if (!Funcionario.ValidarNome(nome))
            {
                MessageBox.Show("Nome inválido!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Funcionario.ValidarUsername(nomeUtilizador))
            {
                MessageBox.Show("Username inválido!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_repositorioFuncionario.NomeUtilizadorExiste(nomeUtilizador))
            {
                MessageBox.Show("Username ja existe!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!isEdit || (isEdit && password.Length > 0))
            {
                var val = Funcionario.ValidarPassword(password);
                if (val != null)
                {
                    MessageBox.Show(val, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            if (!Funcionario.ValidarConfirmacaoPassword(password, confirmacao))
            {
                MessageBox.Show("Password no formato incorreto!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Funcionario.ValidarEmail(email))
            {
                MessageBox.Show("Email no formato incorreto!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (isEdit)
            {
                currentFuncionario.Nome = nome;
                currentFuncionario.NomeUtilizador = nomeUtilizador;
                if (password.Length > 0)
                { 
                    currentFuncionario.Password = password;
                }
                currentFuncionario.Email = email;

                _repositorioFuncionario.AtualizarFuncionario(currentFuncionario);
                MessageBox.Show("Edicao efetuada com sucesso!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Funcionario funcionario = new Funcionario
                {
                    Nome = nome,
                    NomeUtilizador = nomeUtilizador,
                    Password = password,
                    Email = email
                };

                _repositorioFuncionario.AdicionarFuncionario(funcionario);
                MessageBox.Show("Registo efetuado com sucesso!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNome_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Registo_Load(object sender, EventArgs e)
        {
           
        }
    }
}
