using MAVS_Projeto_Windows_Forms.Dominio;
using MAVS_Projeto_Windows_Forms.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAVS_Projeto_Windows_Forms.Repositorio
{
    internal class RepositorioProduto : IRepositorioProduto
    {
        private readonly MAVSContext _context;

        public RepositorioProduto(MAVSContext context)
        {
            _context = context;
        }

        // Através do enumerador obter quais são produtos digitais
        public IEnumerable<ProdutoDigital> ObterProdutosDigitais()
        {
            return _context.ProdutosDigitais.ToList();
        }

        // Através do enumerador obter quais são produtos físicos
        public IEnumerable<ProdutoFisico> ObterProdutosFisicos()
        {
            return _context.ProdutosFisicos.ToList();
        }
    }
}
