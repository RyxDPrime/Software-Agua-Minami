using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AguaMinami.Models
{
    public class Tipo_Producto
    {
        public int idTipo { get; set; }
        public required string Nombre { get; set; }
        public int idMedida { get; set; }
        public required string descripcion { get; set; }

        public Tipo_Producto(string nombre, int medida, string desc)
        {
            Nombre = nombre;
            idMedida = medida;
            descripcion = desc;
        }
    }
}