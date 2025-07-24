using GalpaoEletroLar.Models;

namespace GalpaoEletroLar.Services;

public class ProdutoRepository: IProdutoRepository
{
    List<CadastroProduto> produtos = new List<CadastroProduto>();

    public ProdutoRepository()
    {
        produtos = new List<CadastroProduto>
        {
            new CadastroProduto
            {
                Nome = "Micro-ondas",
                Tipo = TIPO.ELETRO,
                Custo = 350.00m,
                Preco = 599.99m,
                DataEntrada = new DateTime(2025, 07, 22),
                Quantidade = 10,
                Tamanho = null,
                Voltagem = VOLTAGEM.V110
            },
            new CadastroProduto
            {
                Nome = "Sofá 3 Lugares",
                Tipo = TIPO.MOVEL,
                Custo = 800.00m,
                Preco = 1299.90m,
                DataEntrada = new DateTime(2025, 07, 20),
                Quantidade = 5,
                Tamanho = "2.20m",
                Voltagem = null
            }
        };
    }
    
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