using MAVS_Projeto_Windows_Forms.Interface;
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
    public partial class Produtos : Form
    {
        private RepositorioProduto _repositorioProduto;

        public Produtos()
        {
            InitializeComponent();

            // Define o que é mostrado na grid "produtos Digitais"
            _repositorioProduto = new RepositorioProduto(new MAVSContext());
            var produtosD = _repositorioProduto.ObterProdutosDigitais()
                .Select(p => new
                {
                    Nome = p.Nome,
                    Preco = p.Preco,
                    DataCriacao = p.DataCriacao,
                    Tamanho = p.Tamanho,
                    Quantidade = p.Quantidade,
                    Descricao = p.GetDescription(),
                })
                .ToList();
            dataGridView1.DataSource = produtosD;

            // Define o que é mostrado na grid "produtos Físicos"
            var produtosF = _repositorioProduto.ObterProdutosFisicos()
                .Select(p => new
                {
                    Nome = p.Nome,
                    Preco = p.Preco,
                    DataCriacao = p.DataCriacao,
                    Peso = p.Peso,
                    Quantidade = p.Quantidade,
                    Descricao = p.GetDescription(),
                })
                .ToList();
            dataGridView2.DataSource = produtosF;
        }

        // ao clicar no botão voltar, fecha o menu
        private void buttonVoltarProdutos_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
