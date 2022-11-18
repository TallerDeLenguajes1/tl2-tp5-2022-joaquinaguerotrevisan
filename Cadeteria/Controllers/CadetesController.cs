using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using Cadeteria.Models;
using AutoMapper;
using Cadeteria.ViewModels;

namespace Cadeteria.Controllers
{
    public class CadetesController : Controller
    {
        private readonly ILogger<CadetesController> _logger;

        private IMapper _mapper;

        private readonly RepositorioCadetes Repositorio_Cadetes = new RepositorioCadetes();

        public CadetesController(ILogger<CadetesController> logger, IMapper mapper)
        {
            _logger = logger;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Mostrar_Cadetes()
        {
            var Lista_Cadetes_VM = _mapper.Map<List<CadeteViewModel>>(Repositorio_Cadetes.Get_Cadetes());
            return View(Lista_Cadetes_VM);
        }

        public IActionResult Alta_Cadetes()
        {
            return View(new CadeteViewModel());
        }

        [HttpPost]
        public IActionResult Cargar_Cadete(CadeteViewModel _Cadete)
        {
            Repositorio_Cadetes.Add_Cadete(_mapper.Map<Cadete>(_Cadete));
            return RedirectToAction("Mostrar_Cadetes");
        }

        public IActionResult Baja_Cadetes(int _Id_Cadete)
        {
            Repositorio_Cadetes.Baja_Cadete(_Id_Cadete);

            return RedirectToAction("Mostrar_Cadetes");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}