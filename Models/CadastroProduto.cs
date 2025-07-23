using System.Runtime.InteropServices.JavaScript;
using System.Security.Cryptography.X509Certificates;

namespace GalpaoEletroLar.Models;

public class CadastroProduto
{
    public string Nome { get; set; }
    
    public PublicKey Id { get; set; }
    
    public TIPO Tipo { get; set; }
    
    public DateTime DataEntarda { get; set; }
    
    public decimal custo { get; set; }
    
    public decimal preco { get; set; }
    
    public int quantidade { get; set; }
    
    public bool emPromocao { get; set; }
    
    
}