using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AguaMinami.Models
{
    public class RecetaCabecera
    {
        public int idReceta { get; }
        public int idVariante { get; set;}
        public required string nombre { get; set; }
        public required string descripcion { get; set;}

        public RecetaCabecera (int variante, string nombre, string desc)
        {
            idVariante = variante;
            this.nombre = nombre;
            descripcion = desc;
        }
    }
}