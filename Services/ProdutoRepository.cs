using GalpaoEletroLar.Models;

namespace GalpaoEletroLar.Services;

public class ProdutoRepository: IProdutoRepository
{
    List<CadastroProduto> produtos = new List<CadastroProduto>();
    
    public void CriaProduto(CadastroProduto produto)
    {
        produtos.Add(produto);
    }
    
    public void AtualizaProduto(CadastroProduto produto) {}
    
    public void DeletaProduto(CadastroProduto produto) {}

    public List<CadastroProduto> GetProdutos()
    {
        return produtos;
    }
}