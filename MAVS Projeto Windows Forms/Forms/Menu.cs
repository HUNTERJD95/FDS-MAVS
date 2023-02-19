using MAVS_Projeto_Windows_Forms.Dominio;
using MAVS_Projeto_Windows_Forms.Repositorio;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAVS_Projeto_Windows_Forms
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {
        }

        private void consultarFuncionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        // Botão terminar sessão, fecha e envia para login form
        private void buttonSairMenu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Até à próxima " + Sessao.FuncionarioAutenticado?.Nome + "!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Sessao.FuncionarioAutenticado = null; // Limpa sessão existente
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void consultarProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Botão Funcionários envia para o form respetivo
        private void buttonFuncionarios_Click(object sender, EventArgs e)
        {
            Funcionarios funcionarios = new Funcionarios();
            funcionarios.Show();
        }

        // Botão produtos envia para form respetivo
        private void buttonProdutos_Click(object sender, EventArgs e)
        {
            Produtos produtos = new Produtos();
            produtos.Show();
        }
    }
}
