using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cadeteria.Models
{
    public class Cadete
    {
        //ATRIBUTO/S ---
        static private int Autonumerico = 0;
        private int id;
        private string? nombre;
        private string? domicilio;
        private string? telefono;

        public int Id { get => id; set => id = value; }
        public string? Nombre { get => nombre; set => nombre = value; }
        public string? Domicilio { get => domicilio; set => domicilio = value; }
        public string? Telefono { get => telefono; set => telefono = value; }

        // CONSTRUCTOR ---
        public Cadete(string? _Nombre, string? _Domicilio, string? _Telefono)
        {
            Autonumerico++;
            this.Id = Autonumerico;
            this.Nombre = _Nombre;
            this.Domicilio = _Domicilio;
            this.Telefono = _Telefono;
        }

        public Cadete()
        {
            Autonumerico++;
            this.Id = Autonumerico;
            this.Nombre = "";
            this.Telefono = "";
            this.Domicilio = "";
        }
    }
}