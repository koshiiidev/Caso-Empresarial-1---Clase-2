using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario
{
    public class Accesorio : Producto
    {
        //Atributos
        public int Peso { get; set; }
        public Accesorio(string nombre, decimal precio, string codigo) : base(nombre, precio, codigo)
        {
        }

        public override void MostrarDetalles()
        {
            Console.WriteLine($"Tablet: {Nombre}, Peso: {Peso}, Precio: {Precio}");
        }

        public override void Editar()
        {
            Console.WriteLine("Ingrese el nuevo valor de peso: ");
            Peso = int.Parse(Console.ReadLine());
        }
    }
}
