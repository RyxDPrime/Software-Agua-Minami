using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AguaMinami.Models
{
    public class UnidadMedida
    {
        public int idMedida { get;}
        public required string Nombre { get; set; }
        public required string abreviatura { get; set; }
        public required string descripcion { get; set; }

        public UnidadMedida(string nombre, string abreviatura, string desc)
        {
            Nombre = nombre;
            this.abreviatura = abreviatura;
            descripcion = desc;
        }
    }
}