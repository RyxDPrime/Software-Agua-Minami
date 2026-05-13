using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/*
    Clase RecetaDetalle

    Clase para especificar cantidad de materia prima que conlleva hacer un producto
    Ejemplo: Botellon de agua lleva:
    - 1 botellon plastico
    - 1 Cintillo
    - 1 Etiqueta
    - x galones de agua
    Entonces, esta receta deberia tener 4 RecetaDetalle
*/
namespace AguaMinami.Models
{
    public class RecetaDetalle
    {
        public int idReceta { get; }
        public int idRecetaCabecera { get; set; }
        public int varianteInsumo { get; set; } 
        public int Cantidad { get; set; }

        public RecetaDetalle (int idCabecera, int idMateriaPrima, int cant)
        {
            idRecetaCabecera = idCabecera;
            varianteInsumo = idMateriaPrima;
            Cantidad = cant;
        }
    }
}