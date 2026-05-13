using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AguaMinami.Models
{
    public class Categoria
    {
        public int idCategoria { get; }
        public required string Nombre { get; set; }
        public required string descripcion { get; set; }
        public bool eliminado { get; set; }

        public Categoria(string nombre, string desc)
        {
            Nombre = nombre;
            descripcion = desc;
            eliminado = false;
        }
    }
}