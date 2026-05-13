using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AguaMinami.Models
{
    public class DetallesVariante
    {
        public int idDetalle { get; }
        public int idVariante { get; set; }
        public bool retornable { get; set; }
        public bool reutilizable { get; set; }
        public required string descripcion { get; set; }

        public DetallesVariante (int idVariante, bool retornable, bool reutilizable, string descripcion)
        {
            this.idVariante = idVariante;
            this.retornable = retornable;
            this.reutilizable = reutilizable;
            this.descripcion = descripcion;
        }
    }
}