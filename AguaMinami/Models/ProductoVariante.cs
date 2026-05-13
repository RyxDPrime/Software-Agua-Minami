using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AguaMinami.Models
{
    public class ProductoVariante
    {
        public int idVariante { get; }
        public int idProducto { get; set; }
        public int idMedida {get; set;}
        public string nombre { get; set; }
        public int ValorMedida { get; set; } // cantidad de medida/contenido, ejemplo, 50 kg, esta variable seria 50
        public decimal precioVenta { get; set; }
        public int Existencia { get; set; }
        public int stockMinimo { get; set; }
        public bool eliminado { get; set; }
        public string rutaFoto { get; set; }
        
        public ProductoVariante(int idProducto,int idMedida, string nombre, int valorContenido, decimal precio, 
        int existencia, int stockMinimo, string ruta)
        {
            this.idProducto = idProducto;
            this.idMedida = idMedida;
            this.nombre = nombre;
            ValorMedida = valorContenido;
            precioVenta = precio;
            Existencia = existencia;
            this.stockMinimo = stockMinimo;
            rutaFoto = ruta;
            eliminado = false;
        }
    }
}