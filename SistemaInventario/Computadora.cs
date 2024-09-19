using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario
{
    public class Computadora : Producto
    {
        //Atributos
        public int RAM { get; set; }
        public string Procesador { get; set; }

        public Computadora(string nombre, decimal precio, string codigo, int ram, string procesador) : base(nombre, precio, codigo)
        {
            RAM = ram;
            Procesador = procesador;
        }

        public override void MostrarDetalles()
        {
            Console.WriteLine($"Computadora: {Nombre}, RAM: {RAM}, Precio: {Precio}");
        }

        public override void Editar()
        {
            Console.WriteLine("Ingrese el nuevo valor de RAM: ");
            RAM = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el nuevo valor de procesador: ");
            Procesador = Console.ReadLine();
        }
    }
}
