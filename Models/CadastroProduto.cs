using System.Runtime.InteropServices.JavaScript;
using System.Security.Cryptography.X509Certificates;

namespace GalpaoEletroLar.Models;

public abstract class CadastroProduto
{
    public string Nome { get; set; }
    
    public TIPO Tipo { get; set; }
    
    public DateTime DataEntarda { get; set; }
    
    public decimal Custo { get; set; }
    
    public decimal Preco { get; set; }
    
    public int Quantidade { get; set; }
    
    public bool EmPromocao { get; set; }
    
    public string Tamanho { get; set; }
    
    public string? Material { get; set; }
    
    public int? Voltagem { get; set; }

    public CadastroProduto() {}
}