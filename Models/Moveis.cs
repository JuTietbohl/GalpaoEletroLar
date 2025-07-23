using System.Security.Cryptography.X509Certificates;

namespace GalpaoEletroLar.Models;

public class Moveis : CadastroProduto
{
    public string Material { get; set; }

    public Moveis(string nome, PublicKey id, TIPO tipo, DateTime dataEntrada, decimal custo,
        decimal preco, int quantidade, bool emPromocao, string tamanho, string materil) :
        base(nome, id, tipo, dataEntrada, custo, preco, quantidade, emPromocao, tamanho)
    {
        Material = materil;
    }
}