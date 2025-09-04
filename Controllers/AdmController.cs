using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Projeto_FrontEnd_com_C_.Models;

namespace Projeto_FrontEnd_com_C_.Controllers;

public class AdmController : Controller
{
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


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
