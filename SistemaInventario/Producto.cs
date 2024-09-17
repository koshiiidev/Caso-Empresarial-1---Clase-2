using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario
{
    public abstract class Producto
    {


        //Atributos

        protected string Nombre;
        protected decimal Precio;
        protected string Codigo;

        //Constructor

        public Producto(string nombre, decimal precio, string codigo)
        {
            Nombre = nombre;
            Precio = precio;
            Codigo = codigo;
        }

        //Getters & Setters


        public string GetNombre()
        {
            return Nombre;
        }

        public void SetNombre(string value)
        {
            Nombre = value;
        }

        public decimal GetPrecio()
        {
            return Precio;
        }

        public void SetPrecio(decimal value)
        {
            Precio = value;
        }

        public string GetCodigo()
        {
            return Codigo;
        }

        public void SetCodigo(string value)
        {
            Codigo = value;
        }


        //Metodos
        public abstract void MostrarDetalles();


    }
}
