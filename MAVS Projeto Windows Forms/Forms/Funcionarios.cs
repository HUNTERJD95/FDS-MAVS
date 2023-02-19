using MAVS_Projeto_Windows_Forms.Dominio;
using MAVS_Projeto_Windows_Forms.Repositorio;
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
    public partial class Funcionarios : Form
    {
        private RepositorioFuncionario _repositorioFuncionario;

        public Funcionarios()
        {
            InitializeComponent();

            _repositorioFuncionario = new RepositorioFuncionario(new MAVSContext());
        }

        private void Funcionarios_Load(object sender, EventArgs e)
        {
            LoadListData();

            // Percorre as colunas e ao encontrar "Password" torna-a invisível para não aparecer na tabela
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                if (column.Name == "Password")
                {
                    column.Visible = false;
                }
            }
        }

        private void LoadListData()
        {
            _repositorioFuncionario = new RepositorioFuncionario(new MAVSContext());
            var funcionarios = _repositorioFuncionario.ObterFuncionarios();
            dataGridView1.DataSource = funcionarios; // Apresenta na grid a tabela funcionários
        }

        // Ao clicar no botão "Adicionar" abre form de registo
        private void button1_Click(object sender, EventArgs e)
        {
            Registo registo = new Registo();
            registo.Show();
        }

        // Ao clicar no botão "Voltar" fecha form e abre form principal
        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }

        // Ao clicar no botão "Editar" permite a edição de um funcionário
        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0) // Confirma se selecionaram uma linha
            {
                string? funcionarioId = dataGridView1.SelectedRows[0].Cells["Id"].Value.ToString() ?? null;
                if (funcionarioId != null)
                {
                    Registo registo = new Registo(int.Parse(funcionarioId));
                    registo.Show();
                }
            }
        }

        // Ao clicar no botão "Remover", permite remoção de funcionário
        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0) // Confirma se selecionaram uma linha
            {
                string? funcionarioId = dataGridView1.SelectedRows[0].Cells["Id"].Value.ToString() ?? null;
                if (funcionarioId != null)
                {
                    _repositorioFuncionario.RemoverFuncionario(int.Parse(funcionarioId));
                    MessageBox.Show("Funcionario removido com successo");
                    LoadListData();
                }
            }
        }
    }
}
