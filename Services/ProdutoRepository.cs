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

    public void DeletaProduto(CadastroProduto produto)
    {
    }

    public List<CadastroProduto> GetProdutos()
    {
        return produtos;
    }

    public void PrintProdutos()
    {
        Console.WriteLine(produtos.Count);
        foreach (CadastroProduto produto in produtos)
        {
            Console.WriteLine($"Nome: {produto.Nome}");
            Console.WriteLine($"Custo: {produto.Custo}");
            Console.WriteLine($"Quantidade: {produto.Quantidade}");
            Console.WriteLine($"Data de entrada:  {produto.DataEntrada}");
            Console.WriteLine($"Quantidade:  {produto.Quantidade}");
            Console.WriteLine($"Voltagem: {produto.Voltagem}");
            Console.WriteLine($"Tipo: {produto.Tipo}");
            Console.WriteLine($"Em promocao: {produto.EmPromocao}");
        }
    }
}