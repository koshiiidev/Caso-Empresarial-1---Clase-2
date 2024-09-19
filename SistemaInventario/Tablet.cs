using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario
{
    public class Tablet : Producto
    {
        //Atributos

        public string SistemaOperativo { get; set; }
        public Tablet(string nombre, decimal precio, string codigo, string sistemaOperativo) : base(nombre, precio, codigo)
        {
            SistemaOperativo = sistemaOperativo;
        }

        public override void MostrarDetalles()
        {
            Console.WriteLine($"Tablet: {Nombre}, Sistema Operativo: {SistemaOperativo}, Precio: {Precio}");
        }

        public override void Editar()
        {
            Console.WriteLine("Ingrese el nuevo valor de sistema operativo: ");
            SistemaOperativo = Console.ReadLine();
        }
    }
}
