using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cadeteria.Models
{
    public class Pedido
    {
        private int id;
        private string? observaciones;
        private float precio;
        private bool estado;

        public int Id { get => id; set => id = value; }
        public string? Observaciones { get => observaciones; set => observaciones = value; }
        public float Precio { get => precio; set => precio = value; }
        public bool Estado { get => estado; set => estado = value; }

        Pedido(string? _observaciones, float _precio)
        {
            observaciones = _observaciones;
            precio = _precio;
        }

        Pedido()
        {
            observaciones = "";
            precio = 0;
        }
    }
}