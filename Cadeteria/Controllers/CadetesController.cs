using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Cadeteria.Models;

namespace Cadeteria.Controllers
{
    public class CadetesController : Controller
    {
        private readonly ILogger<CadetesController> _logger;
        private static List<Cadete> Lista_Cadete = new List<Cadete>();

        public CadetesController(ILogger<CadetesController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Mostrar_Cadetes()
        {
            return View(Lista_Cadete);
        }

        public IActionResult Alta_Cadetes()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cargar_Cadete(Cadete _Cadete)
        {
            Lista_Cadete.Add(_Cadete);
            return RedirectToAction("Mostrar_Cadetes");
        }

        public IActionResult Baja_Cadetes(int _Id_Cadete)
        {
            Cadete? Cadete_Buscar = Lista_Cadete.Find( Cadete => Cadete.Id == _Id_Cadete);

            if (Cadete_Buscar != null) 
            {
                Lista_Cadete.Remove(Cadete_Buscar);
            }

            return RedirectToAction("Mostrar_Cadetes");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}