using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAVS_Projeto_Windows_Forms.Dominio
{
    // Classe ProdutoFisico que herda de Produto
    public class ProdutoFisico : Produto
    {
        public decimal Peso { get; set; }

        // Função abstrata aplicada a produto físico 
        public override string GetDescription()
        {
            return $"{Nome} ({Preco:C}) - Peso: {Peso}";
        }
    }
}
