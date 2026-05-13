using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AguaMinami.Models
{
    public class Alerta_Stock_Minimo : Alerta
    {
        public int idProducto { get; set; }
        public ProductoVariante producto;

        public void alertar()
        {
            if(producto.Existencia < producto.stockMinimo)
            {
                throw 
            }
        }
    }
}