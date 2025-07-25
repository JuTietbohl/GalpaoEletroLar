using GalpaoEletroLar.Models;

namespace GalpaoEletroLar.Services;

public class ProdutoRepository: IProdutoRepository
{
    private List<CadastroProduto> produtos = new List<CadastroProduto>();
    private int ultimoId = 0;

    public ProdutoRepository()
    {
        produtos = new List<CadastroProduto>
        {
            new CadastroProduto
            {
                Id = ++ultimoId,
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
                Id = ++ultimoId,
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
        produto.Id = ++ultimoId;
        produtos.Add(produto);
    }

    public void AtualizaProduto(CadastroProduto produtoAtualizado)
    {
        var produtoExistente = produtos.FirstOrDefault(p => p.Id == produtoAtualizado.Id);
        if (produtoExistente != null)
        {
            produtoExistente.Nome = produtoAtualizado.Nome;
            produtoExistente.Tipo = produtoAtualizado.Tipo;
            produtoExistente.Voltagem = produtoAtualizado.Voltagem;
            produtoExistente.DataEntrada = produtoAtualizado.DataEntrada;
            produtoExistente.Custo = produtoAtualizado.Custo;
            produtoExistente.Preco = produtoAtualizado.Preco;
            produtoExistente.Quantidade = produtoAtualizado.Quantidade;
            produtoExistente.Tamanho = produtoAtualizado.Tamanho;
            produtoExistente.EmPromocao = produtoAtualizado.EmPromocao;
        }
    }


    public void DeletaProduto(int id)
    {
        CadastroProduto? produto = produtos.FirstOrDefault(p => p.Id == id);

        if (produto != null)
        {
            produtos.Remove(produto);
        }

    }

    public List<CadastroProduto> GetProdutos()
    {
        return produtos;
    }

    public CadastroProduto? GetProduto(int id)
    {
        return produtos.FirstOrDefault(p => p.Id == id);
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