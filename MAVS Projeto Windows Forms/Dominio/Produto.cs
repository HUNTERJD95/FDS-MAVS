using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAVS_Projeto_Windows_Forms.Dominio
{
    // Classe Produto
    public abstract class Produto
    {
        [Key]
        public int Id { get; set; }

        public string? Nome { get; set; }

        public decimal Preco { get; set; }

        public int Quantidade { get; set; }

        public DateTime DataCriacao { get; set; }

        // Este método pode dar return à descrição do produto, que pode ser diferente para cada sub classe do produto
        public abstract string GetDescription();

    }
}
