
namespace AguaMinami.Models
{
    public class Producto
    {
        private int idProducto;
        private string nombre;
        private int idCategoria;
        private int idTipo;
        private int idMarca;
        private string rutaFoto;
        private string descripcion;
        private bool eliminado;
        private bool esInsumo;

        public int IdProducto { get => idProducto; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int IdCategoria { get => idCategoria; set => idCategoria = value; }
        public int IdTipo { get => idTipo; set => idTipo = value; }
        public int IdMarca { get => idMarca; set => idMarca = value; }
        public string RutaFoto { get => rutaFoto; set => rutaFoto = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public bool Eliminado { get => eliminado; set => eliminado = value; }
        public bool EsInsumo { get => esInsumo; set => esInsumo = value; }

        public void producto(string nombre, int idCategoria, int idTipo,
        int idMarca, string ruta, string descripcion, bool esInsumo)
        {
            Nombre = nombre;
            this.idCategoria = idCategoria;
            IdTipo = idTipo;
            IdMarca = idMarca;
            RutaFoto = ruta;
            Descripcion = descripcion;
            this.esInsumo = esInsumo;
            Eliminado = false;
        }
    }
}