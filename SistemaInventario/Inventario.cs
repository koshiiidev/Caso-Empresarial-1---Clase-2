using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario
{
    public class Inventario : IGestionInventario
    {


            //Atributo
        private List<Producto> Productos = new List<Producto>();

        public void AgregarProducto(Producto producto)
        {
            Productos.Add(producto);
            Console.WriteLine($"Producto: {producto.GetNombre} agregado correctamente al inventario");
        }

        public void EditarProducto(string codigoProducto)
        {
            foreach (Producto producto in Productos)
            {
                if (producto.GetCodigo().Equals(codigoProducto))
                {
                    producto.Editar();
                    //Console.WriteLine($"El producto codigo {codigoProducto} ha sido eliminado");
                    return;
                }

            }
            Console.WriteLine("No se han encontrado productos con el codigo ingresado.");
        }

        public void EliminarProducto(string codigoProducto)
        {
            foreach (Producto producto in Productos) 
            {
                if (producto.GetCodigo().Equals(codigoProducto))
                {
                    Productos.Remove(producto);
                    Console.WriteLine($"El producto codigo {codigoProducto} ha sido eliminado");
                    return;
                }  
                
            }
            Console.WriteLine("No se han encontrado productos con el codigo ingresado.");

        }

        public void MostrarProductos()
        {
            /*
            for (int i = 0; i < Productos.Count; i++) 
            {
                Console.WriteLine(Productos[i].MostrarDetalles);
            }
            */

            foreach (Producto producto in Productos) 
            {
                producto.MostrarDetalles();
            }
        }
    }




        //Metodos Agregar, Mostrar, Editar, Eliminar


    
}
