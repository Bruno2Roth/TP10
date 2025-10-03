using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP10.Models;

namespace TP10.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
    public IActionResult ConfigurarJuego()
    {
        return RedirectToAction("Jugar");
    }
    public IActionResult Comenzar(string username, int categoria)
    {
        return View("Juego");
    }
    public IActionResult Jugar()
    {
        return View("Juego");
    }
    [HttpPost]
    public IActionResult VerificarRespuesta(int idPregunta, int idRespuesta)
    {
        //

        return View("Respuesta");
    }

}
