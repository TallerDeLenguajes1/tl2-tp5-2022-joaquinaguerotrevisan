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
    public class PedidosController : Controller
    {
        private readonly ILogger<PedidosController> _logger;

        private IMapper _mapper;

        private readonly RepositorioPedido Repositorio_Pedido = new RepositorioPedido();

        public PedidosController(ILogger<PedidosController> logger, IMapper mapper)
        {
            _logger = logger;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Mostrar_Pedidos()
        {
            var Lista_Pedidos_VM = _mapper.Map<List<PedidoViewModel>>(Repositorio_Pedido.Get_Pedidos());
            return View(Lista_Pedidos_VM);
        }
        
        public IActionResult Alta_Pedidos()
        {
            return View(new PedidoViewModel());
        }

        [HttpPost]
        public IActionResult Cargar_Pedido(PedidoViewModel _Pedido)
        {
            Repositorio_Pedido.Add_Pedido(_mapper.Map<Pedido>(_Pedido));
            return RedirectToAction("Mostrar_Pedidos");
        }       
        
        public IActionResult Baja_Pedidos(int _Id_Pedido)
        {
            Repositorio_Pedido.Baja_Pedido(_Id_Pedido);

            return RedirectToAction("Mostrar_Pedidos");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}