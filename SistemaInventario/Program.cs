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
                Console.WriteLine("-----AGREGANDO PRODUCTO-----");
                Console.WriteLine("-----1. Agregar Computadora ");
                Console.WriteLine("-----2. Agregar Telefono");
                Console.WriteLine("-----3. Agregar Tablet");
                Console.WriteLine("-----4. Agregar Accesorios");
                string opcionProducto = Console.ReadLine();

                Console.WriteLine("-----Escriba el nombre del producto-----");
                string Nombre = Console.ReadLine();
                Console.WriteLine("-----Escriba el precio del producto-----");
                decimal Precio = decimal.Parse(Console.ReadLine());
                Console.WriteLine("-----Escriba el codigo del producto-----");
                string Codigo = Console.ReadLine();

                switch (opcionProducto)
                {
                    case "1":
                        
                        Console.WriteLine("-----Escriba la RAM del producto-----");
                        int RAM = int.Parse(Console.ReadLine());
                        Console.WriteLine("-----Escriba el procesador del producto-----");
                        string Procesador = Console.ReadLine();
                        Computadora pc = new Computadora(Nombre, Precio, Codigo, RAM, Procesador);
                        inventarioTiendaUno.AgregarProducto(pc);
                        Console.WriteLine($"****La computadora {pc.GetNombre} fue agregada.****");


                        break;

                    case "2":

                        Console.WriteLine("-----Escriba la camara del telefono-----");
                        string CamaraTelefono = Console.ReadLine();
                        Telefono telefono = new Telefono(Nombre, Precio, Codigo, CamaraTelefono);
                        inventarioTiendaUno.AgregarProducto(telefono);
                        Console.WriteLine($"****El telefono {telefono.GetNombre} fue agregado.****");


                        break;

                    case "3":

                        Console.WriteLine("-----Escriba el sistema operativo de la Tablet-----");
                        string SistemaOperativo = Console.ReadLine();
                        Tablet tablet = new Tablet(Nombre, Precio, Codigo, SistemaOperativo);
                        inventarioTiendaUno.AgregarProducto(tablet);
                        Console.WriteLine($"****La tablet {tablet.GetNombre} fue agregado.****");


                        break;

                    case "4":
                        
                        Console.WriteLine("-----Escriba el peso del accesorio-----");
                        int PesoAccesorio = int.Parse(Console.ReadLine());
                        Accesorio accesorio = new Accesorio(Nombre, Precio, Codigo, PesoAccesorio);
                        inventarioTiendaUno.AgregarProducto(accesorio);
                        Console.WriteLine($"****El accesorio {accesorio.GetNombre} fue agregado.****");


                        break;

                    default:
                        break;
                }

                Console.WriteLine("***Agregando producto***");
                Console.WriteLine("Ingrese el precio del producto");
                decimal precioProducto = decimal.Parse(Console.ReadLine());
                break;

            case "2":
                Console.WriteLine("-----Editando producto----- \n Ingrese el Codigo del producto a editar: ");
                string codigoProducto = Console.ReadLine();
                inventarioTiendaUno.EditarProducto(codigoProducto);
                break;

            case "3":
                Console.WriteLine("-----Mostrando productos-----");
                inventarioTiendaUno.MostrarProductos();
                break;

            case "4":
                Console.WriteLine("-----Eliminando producto-----\n Ingrese el Codigo del producto a eliminar");
                string codProducto = Console.ReadLine();
                inventarioTiendaUno.EliminarProducto(codProducto);
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