using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario
{
    public interface IGestionInventario
    {
        void AgregarProducto(Producto producto);

        void EditarProducto(string codigoProducto);

        void MostrarProductos();

        void EliminarProducto(string codigoProducto);
    }
}
