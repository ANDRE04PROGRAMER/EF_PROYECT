using EF_PROYECT;
using System;
int menu_number, submenu_number;
string opcion_menu_number;
do
{
    do
    {
        Console.Clear();
        Console.WriteLine("MENU PRINCIPAL:");
        Console.WriteLine("1. Carro");
        Console.WriteLine("2. Cliente");
        Console.WriteLine("3. Alquiler");
        Console.WriteLine("0. Salir");
        Console.WriteLine("Seleccione una opcion:");
        opcion_menu_number = Console.ReadLine();
        if (int.TryParse(opcion_menu_number, out menu_number));
    } while (false);
    switch (menu_number)
    {
        case 1:
            do
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("MENU DE CARROS:");
                    Console.WriteLine("1. Crear carro");
                    Console.WriteLine("2. Listar carros");
                    Console.WriteLine("3. Eliminar carro");
                    Console.WriteLine("0. Salir al MENU PRINCIPAL");
                    Console.WriteLine("Seleccione una opcion:");
                    opcion_menu_number = Console.ReadLine();
                    if (int.TryParse(opcion_menu_number, out submenu_number)) ;
                } while (false);
                switch (submenu_number)
                {
                    case 1: 
                        CarroUtil.Crear(); 
                        break;
                    case 2: 
                        CarroUtil.Listar(); 
                        break;
                    case 3: 
                        CarroUtil.Eliminar(); 
                        break;
                    case 0:
                        CarroUtil.Salir();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Opcion no valida...");
                        Console.WriteLine("Precione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;
                }
            } while (submenu_number != 0);
            break;
        case 2:
            do
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("MENU DE CLIENTES:");
                    Console.WriteLine("1. Crear cliente");
                    Console.WriteLine("2. Listar clientes");
                    Console.WriteLine("3. Eliminar cliente");
                    Console.WriteLine("0. Salir al MENU PRINCIPAL");
                    Console.WriteLine("Seleccione una opcion:");
                    opcion_menu_number = Console.ReadLine();
                    if (int.TryParse(opcion_menu_number, out submenu_number)) ;
                } while (false);
                switch (submenu_number)
                {
                    case 1:
                        ClienteUtil.Crear();
                        break;
                    case 2:
                        ClienteUtil.Listar();
                        break;
                    case 3:
                        ClienteUtil.Eliminar();
                        break;
                    case 0:
                        ClienteUtil.Salir();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Opcion no valida...");
                        Console.WriteLine("Precione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;
                }
            } while (submenu_number != 0);
            break;
        case 3:
            do
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("MENU DE ALQUILERES:");
                    Console.WriteLine("1. Crear alquiler");
                    Console.WriteLine("2. Listar alquileres");
                    Console.WriteLine("3. Carros que un cliente puede alquilar");
                    Console.WriteLine("4. Eliminar alquiler");
                    Console.WriteLine("0. Salir al MENU PRINCIPAL");
                    Console.WriteLine("Seleccione una opcion:");
                    opcion_menu_number = Console.ReadLine();
                    if (int.TryParse(opcion_menu_number, out submenu_number)) ;
                } while (false);
                switch (submenu_number)
                {
                    case 1:
                        AlquilerUtil.Crear();
                        break;
                    case 2:
                        AlquilerUtil.Listar();
                        break;
                    case 3:
                        AlquilerUtil.CarrosAAlquilar();
                        break;
                    case 4:
                        AlquilerUtil.Eliminar();
                        break;
                    case 0:
                        AlquilerUtil.Salir();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Opcion no valida...");
                        Console.WriteLine("Precione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;
                }
            } while (submenu_number != 0);
            break;
        case 0:
            Console.Clear();
            Console.WriteLine("El programa ha terminado...");
            Console.WriteLine("Precione cualquier tecla para continuar...");
            Console.ReadKey();
            break;
        default:
            Console.Clear();
            Console.WriteLine("Opcion no valida...");
            Console.WriteLine("Precione cualquier tecla para continuar...");
            Console.ReadKey();
            break;
    }
} while (menu_number!=0);