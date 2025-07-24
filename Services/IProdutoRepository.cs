using GalpaoEletroLar.Models;

namespace GalpaoEletroLar.Services;

public interface IProdutoRepository
{
    void CriaProduto(CadastroProduto produto);
    void AtualizaProduto(CadastroProduto produto);
    void DeletaProduto(CadastroProduto produto);
    List<CadastroProduto> GetProdutos();
    void PrintProdutos();
}