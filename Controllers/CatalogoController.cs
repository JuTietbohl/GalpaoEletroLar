using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using GalpaoEletroLar.Models;
using GalpaoEletroLar.Models.ViewModels;
using GalpaoEletroLar.Services;

namespace GalpaoEletroLar.Controllers
{
    public class CatalogoController : Controller
    {
        private readonly IProdutoRepository _service;

        public CatalogoController(IProdutoRepository service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var viewModel = new CatalogoViewModel
            {
                Produto = new CadastroProduto(),
                ListaProdutos = _service.GetProdutos()
            };

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Index(CatalogoViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                viewModel.Produto.EmPromocao = false;
                _service.CriaProduto(viewModel.Produto);

                return RedirectToAction("Index"); 
            }

            viewModel.ListaProdutos = _service.GetProdutos();
            return View(viewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}