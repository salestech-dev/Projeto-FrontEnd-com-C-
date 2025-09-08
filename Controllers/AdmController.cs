using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Projeto_FrontEnd_com_C_.Models;
using Projeto_FrontEnd_com_C_.Repo;

namespace Projeto_FrontEnd_com_C_.Controllers;


public class AdmController : Controller
{
    private readonly iFoodApp _context;
    public AdmController(iFoodApp context)
    {
        _context = context;
    }
    private readonly ILogger<AdmController> _logger;



    public AdmController(ILogger<AdmController> logger)
    {
        _logger = logger;
    }

    public IActionResult AdmLogin()
    {
        return View();
    }
    public IActionResult AdmDashboard()
    {
        return View();
    }

    public IActionResult CadastrarProdutos()
    {
        return View();
    }

    [HttpPost]

    public IActionResult CadastrarProdutos(Models.Produto produto, [FromServices] Repo.iFoodApp repo)
    {
        repo.AddProduto(produto);
        if (produto == null)
        {
            return View();
        }
        else
        {
            ViewBag.Mensagem = "Produto cadastrado com sucesso!";
        }
        return RedirectToAction("AdmDashboard");
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
