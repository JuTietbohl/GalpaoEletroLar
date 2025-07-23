using System.Security.Cryptography.X509Certificates;

namespace GalpaoEletroLar.Models;

public class Eletrodomestico : CadastroProduto
{
    public int Voltagem { get; set; } 
        
    public Eletrodomestico(string nome, PublicKey id, TIPO tipo, DateTime dataEntrada, decimal custo, 
        decimal preco, int quantidade, bool emPromocao, string tamanho, int voltagem) : 
        base(nome, id, tipo, dataEntrada, custo, preco, quantidade, emPromocao, tamanho)
    {
        Voltagem = voltagem;
    }
}