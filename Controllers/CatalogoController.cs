using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using GalpaoEletroLar.Models;
using GalpaoEletroLar.Services;

namespace GalpaoEletroLar.Controllers;

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
        return View();
    }

    [HttpPost]
    public IActionResult Index(CadastroProduto produto)
    {
        if (ModelState.IsValid)
        {
            _service.CriaProduto(produto);
        }
        
        List<CadastroProduto> produtos = _service.GetProdutos();
        Console.WriteLine(produtos);
        return View(produtos);
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