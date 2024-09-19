// See https://aka.ms/new-console-template for more information
using SistemaInventario;



Inventario inventarioTiendaUno = new Inventario();

//Menu

bool continuar = true;

do
{
    try
    {
        Console.WriteLine("-----Seleccione una opcion:-----");
        Console.WriteLine("-----1. Agregar producto ");
        Console.WriteLine("-----2. Editar producto");
        Console.WriteLine("-----3. Mostrar producto");
        Console.WriteLine("-----4. Eliminar producto");
        Console.WriteLine("-----5. Salir");

        string opcion = Console.ReadLine();

        switch (opcion)
        {
            case "1":
                Console.WriteLine("***Agregando producto***");
                Console.WriteLine("Ingrese el precio del producto");
                decimal precioProducto = decimal.Parse(Console.ReadLine());
                break;

            case "2":
                Console.WriteLine("Editando producto");
                break;

            case "3":
                Console.WriteLine("Mostrando productos");
                break;

            case "4":
                Console.WriteLine("Eliminando producto");
                break;

            case "5":
                Console.WriteLine("----- Saliendo... -----");
                continuar = false;
                break;
            default:
                Console.WriteLine("Opcion incorrecta");
                break;
        }
    }
    catch (Exception e)
    {
        Console.WriteLine($"Ha ocurrido un error, Error {e.Message}");
    }

} while (continuar);