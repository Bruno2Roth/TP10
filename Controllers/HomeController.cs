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

        ViewBag.Categorías = BD.ObtenerCategorias();

        return RedirectToAction("Jugar");
    }

    public IActionResult Comenzar(string username, int categoría)
    {
        Juego j = new Juego();
        j.CargarPartida(username, categoría);

        HttpContext.Session.SetString("Partida", Objeto.ObjectToString(j));

        return View("Juego");
    }

    public IActionResult Jugar()
    {
        Juego j = Objeto.StringToObject<Juego>(HttpContext.Session.GetString("Partida"));

        if (j.verificarPreguntasRestantes())
        {
            return View("Fin");
        }

        Pregunta p = j.ObtenerProximaPregunta();
        ViewBag.Pregunta = p;
        ViewBag.Respuestas = j.ObtenerProximasRespuestas(p.ID);

        HttpContext.Session.SetString("Partida", Objeto.ObjectToString(j));

        return View("Juego");
    }

    [HttpPost]
    public IActionResult VerificarRespuesta(int idPregunta, int idRespuesta)
    {
        Juego j = Objeto.StringToObject<Juego>(HttpContext.Session.GetString("Partida"));

        ViewBag.Resultado = j.VerificarRespuesta(idRespuesta);

        return View("Respuesta");
    }

}
