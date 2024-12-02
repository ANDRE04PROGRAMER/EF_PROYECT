using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace EF_PROYECT
{
    public class ClienteUtil
    {
        public static Cliente[] clientes = new Cliente[100];
        public static Cliente cli = new Cliente();
        public static Random r = new Random();
        public static int cant_cli = 0;
        public static int cli_elim_n = 0;
        public static int cli_elim_n_c = 0;
        public static (int, Cliente[]) Crear()
        {
            cant_cli++;
            clientes[cant_cli - 1] = new Cliente
            {
                Nombre = "ABC" + r.Next(1000, 9999).ToString(),
                Dni = r.Next(1, 6),
                PagoMaximo = r.NextDouble() * (1000 - 100) + 100
            };
            Console.Clear();
            Console.WriteLine("Cliente creado con éxito:");
            Console.WriteLine("Inserte DNI del cliente:");
            cli.Dni = int.Parse(Console.ReadLine());
            Console.WriteLine("Inserte nombre del cliente:");
            cli.Nombre = Console.ReadLine();
            Console.WriteLine("Inserte pago maximo del cliente:");
            cli.PagoMaximo = double.Parse(Console.ReadLine());
            clientes[cant_cli - 1].Dni = cli.Dni;
            clientes[cant_cli - 1].Nombre = cli.Nombre;
            clientes[cant_cli - 1].PagoMaximo = cli.PagoMaximo;
            Console.WriteLine($"Cantidad de clientes: {cant_cli}");
            Console.WriteLine("Precione cualquier tecla para continuar...");
            Console.ReadKey();
            return (cant_cli, clientes);
        }
        public static void Listar()
        {
            Console.Clear();
            for (int i = 0; i <= cant_cli - 1; i++)
            {
                Console.WriteLine($"{i+1}° cliente:");
                Console.WriteLine($"{clientes[i].ToString()}");
            }
            Console.WriteLine("Precione cualquier tecla para continuar...");
            Console.ReadKey();
        }
        public static (int, Cliente[]) Eliminar()
        {
            Console.Clear();
            Console.WriteLine("Que cliente desea eliminar?");
            Console.WriteLine("Inserte el numero segun lista del cliente que desea eliminar:");
            cli_elim_n = int.Parse(Console.ReadLine());
            Console.WriteLine("Vuelva a insertar el numero para confirmar:");
            cli_elim_n_c = int.Parse(Console.ReadLine());
            if (cli_elim_n == cli_elim_n_c)
            {
                cli_elim_n--;
                for (int i = 1, j = 0; i < cant_cli && j < cant_cli - 1; i++, j++)
                {
                    clientes[cli_elim_n + j] = clientes[cli_elim_n + i];
                }
                cant_cli--;
                Console.WriteLine("Cliente eliminado con exito...");
                Console.WriteLine($"Cantidad de clientes: {cant_cli}");
                Console.WriteLine("Precione cualquier tecla para continuar...");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("No se ha confirmado la orden de eliminacion...");
                Console.WriteLine("Precione cualquier tecla para continuar...");
                Console.ReadKey();
            }
            return (cant_cli, clientes);
        }
        public static void Salir()
        {
            Console.Clear();
            Console.WriteLine("Saliendo al MENU PRINCIPAL...");
            Console.WriteLine("Precione cualquier tecla para continuar...");
            Console.ReadKey();
        }
    }
}
