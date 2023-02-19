using MAVS_Projeto_Windows_Forms.Dominio;

namespace MAVS_Projeto_Windows_Forms.Interface
{
    public interface IRepositorioProduto
    {
        IEnumerable<ProdutoDigital> ObterProdutosDigitais();

        IEnumerable<ProdutoFisico> ObterProdutosFisicos();
    }
}
