using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAVS_Projeto_Windows_Forms.Dominio
{
    // Classe ProdutoDigital que herda de Produto
    public class ProdutoDigital : Produto
    {
        public decimal Tamanho { get; set; }

        // Função abstrata aplicada a produto digital 
        public override string GetDescription()
        {
            return $"{Nome} ({Preco:C}) - Tamanho de Download: {Tamanho}";
        }
    }
}
