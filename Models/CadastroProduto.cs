using System.Runtime.InteropServices.JavaScript;
using System.Security.Cryptography.X509Certificates;

namespace GalpaoEletroLar.Models;

public class CadastroProduto
{
    public string Nome { get; set; }
    
    public PublicKey Id { get; set; }
    
    public TIPO Tipo { get; set; }
    
    public DateTime DataEntarda { get; set; }
    
    public decimal Custo { get; set; }
    
    public decimal Preco { get; set; }
    
    public int Quantidade { get; set; }
    
    public bool EmPromocao { get; set; }
    
    public string Tamanho { get; set; }

    protected CadastroProduto(string nome, PublicKey id ,TIPO tipo, DateTime dataEntarda, 
        decimal custo, decimal preco, int quantidade, bool emPromocao, string tamanho)
    {
        Nome = nome;
        Id = id;
        Tipo = tipo;
        DataEntarda = dataEntarda;
        Custo = custo;
        Preco = preco;
        Quantidade = quantidade;
        EmPromocao = emPromocao;
        Tamanho = tamanho;
    }
}