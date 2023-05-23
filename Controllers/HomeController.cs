using Microsoft.AspNetCore.Mvc;

namespace TPBase.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        
    ViewBag.ListaResultante = Info.ListarPaises();
    return View();
    }
    public IActionResult DetallePais(string pais)
    {
    ViewBag.Pais = Info.DetallePais(pais);
    return View();
    }
}
