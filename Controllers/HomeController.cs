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
        List<Categoria> Cat = BD.ObtenerCategorias();
        Categoria t = new Categoria("Todas");
        Cat.Add(t);

        ViewBag.Categorias = Cat;

        return View("ConfigurarJuego");

    }

    public IActionResult Comenzar(string username, int categoria)
    {
        Juego j = new Juego();
        j.CargarPartida(username, categoria);

        HttpContext.Session.SetString("Partida", Objeto.ObjectToString(j));

        return RedirectToAction("Jugar");
    }

    public IActionResult Jugar()
    {
        Juego j = Objeto.StringToObject<Juego>(HttpContext.Session.GetString("Partida"));

        ViewBag.Nombre = j.Username;
        ViewBag.PuntajeActual = j.PuntajeActual;
        ViewBag.NumP = j.ContadorNroPreguntaActual;

        Pregunta p = j.ObtenerProximaPregunta();
        ViewBag.Pregunta = p;
        ViewBag.Respuestas = j.ObtenerProximasRespuestas(p.ID);

        if (!j.verificarPreguntasRestantes())
        {
            return View("Fin");
        }

        HttpContext.Session.SetString("Partida", Objeto.ObjectToString(j));

        return View("Jugar");
    }

    [HttpPost]
    public IActionResult VerificarRespuesta(int idPregunta, int idRespuesta)
    {
        Juego j = Objeto.StringToObject<Juego>(HttpContext.Session.GetString("Partida"));

        ViewBag.Resultado = j.VerificarRespuesta(idRespuesta);

        return View("Respuesta");
    }

}
