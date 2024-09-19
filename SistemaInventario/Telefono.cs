using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario
{
    public class Telefono : Producto
    {
        //Atributos
        public string Camara { get; set; }
        

        public Telefono(string nombre, decimal precio, string codigo, string camara) : base(nombre, precio, codigo)
        {
            Camara = camara;
        }

        public override void MostrarDetalles()
        {
            Console.WriteLine($"Telefono: {Nombre}, Camara: {Camara}, Precio: {Precio}");
        }

        public override void Editar()
        {
            Console.WriteLine("Ingrese el nuevo valor de camara: ");
            Camara = Console.ReadLine();
        }
    }
}
