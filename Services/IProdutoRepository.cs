using GalpaoEletroLar.Models;

namespace GalpaoEletroLar.Services;

public interface IProdutoRepository
{
    void CriaProduto(CadastroProduto produto);
    void AtualizaProduto(CadastroProduto produto);
    void DeletaProduto(int id);
    List<CadastroProduto> GetProdutos();
    
    CadastroProduto GetProduto(int id);
    void PrintProdutos();
}