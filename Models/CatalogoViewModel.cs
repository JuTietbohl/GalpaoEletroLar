namespace GalpaoEletroLar.Models.ViewModels
{
    public class CatalogoViewModel
    {
        public CadastroProduto Produto { get; set; } = new CadastroProduto();
        public List<CadastroProduto> ListaProdutos { get; set; } = new List<CadastroProduto>();
    }
}