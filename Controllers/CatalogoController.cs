using System.Diagnostics;
using System.Text.Json;
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
                Produto = new CadastroProduto
                {
                    DataEntrada = DateTime.Now,
                },
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

                _service.PrintProdutos();
                TempData["Toast"] = "confirmarAdicao()";


                return RedirectToAction("Index");

            }

            viewModel.ListaProdutos = _service.GetProdutos();
            return View(viewModel);
        }

        [HttpGet]
        public IActionResult DetalhesProduto(int id)
        {
            CadastroProduto produto = _service.GetProduto(id);
            if (produto == null)
            {
                return NotFound();
            }
            
            return PartialView("Modal/ModalDetalhes", produto);
        }

        [HttpPost]
        public IActionResult RemoveProduto(int id)
        {
            _service.DeletaProduto(id);
            TempData["Toast"] = "confirmarExclusao()";

            return RedirectToAction("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AlterarProduto(CadastroProduto produto)
        {
            if (produto == null)
                return BadRequest("Produto inválido.");

            _service.AtualizaProduto(produto); // ou o nome do teu método real

            TempData["Toast"] = "confirmarSalvamento()";
            return RedirectToAction("Index");
        }




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}