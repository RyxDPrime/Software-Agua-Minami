using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AguaMinami.Models
{
    public class Marca
    {
        public int idMarca { get; }
        public string Nombre { get; set; }
        public string  descripcion { get; set; }

        public Marca(string nombre, string desc)
        {
            Nombre = nombre;
            descripcion = desc;
        }

    }
}