using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace EF_PROYECT
{
    public class AlquilerUtil
    {
        public static Alquiler[] alquileres = new Alquiler[100];
        public static Alquiler alq = new Alquiler();
        public static Random r = new Random();
        public static int cant_alq = 0;
        public static int alq_elim_n = 0;
        public static int alq_elim_n_c = 0;
        public static int CarroAlq_n = 0;
        public static int Contratante_n = 0;
        public static (int, Alquiler[]) Crear()
        {
            cant_alq++;
            alquileres[cant_alq - 1] = new Alquiler
            {
                Numero = r.Next(1, 6),
                CarroAlq = CarroUtil.carros[0],
                Contratante = ClienteUtil.clientes[0],
                Precio = r.NextDouble() * (1000 - 100) + 100
            };
            Console.Clear();
            Console.WriteLine("Alquiler creado con éxito:");
            Console.WriteLine($"{cant_alq}° alquiler");
            alq.Numero = cant_alq;
            Console.WriteLine("Inserte numero de carro a alquilar:");
            CarroAlq_n = int.Parse(Console.ReadLine());
            alq.CarroAlq = CarroUtil.carros[CarroAlq_n - 1];
            Console.WriteLine("Inserte numero de cliente a alquilar:");
            Contratante_n = int.Parse(Console.ReadLine());
            alq.Contratante = ClienteUtil.clientes[Contratante_n - 1];
            Console.Write("El precio a pagar es de: ");
            alq.Precio = CarroUtil.carros[CarroAlq_n - 1].PrecioAlquiler;
            Console.WriteLine(alq.Precio);
            alquileres[cant_alq - 1].Numero = alq.Numero;
            alquileres[cant_alq - 1].CarroAlq = alq.CarroAlq;
            alquileres[cant_alq - 1].Contratante = alq.Contratante;
            alquileres[cant_alq - 1].Precio = alq.Precio;
            Console.WriteLine($"Cantidad de alquileres: {cant_alq}");
            Console.WriteLine("Precione cualquier tecla para continuar...");
            Console.ReadKey();
            return (cant_alq, alquileres);
        }
        public static void Listar()
        {
            Console.Clear();
            for (int i = 0; i <= cant_alq - 1; i++)
            {
                Console.WriteLine($"{i+1}° alquiler:");
                Console.WriteLine($"{alquileres[i].ToString()}");
            }
            Console.WriteLine("Precione cualquier tecla para continuar...");
            Console.ReadKey();
        }
        public static void CarrosAAlquilar()
        {
            Console.Clear();
            Console.WriteLine("Inserte el numero de cliente:");
            Contratante_n = int.Parse(Console.ReadLine());
            Console.WriteLine("El pago maximo del cliente es:");
            Console.WriteLine(ClienteUtil.clientes[Contratante_n - 1].PagoMaximo);
            Console.WriteLine("Los carros que puede alquilar son:");
            for (int i = 1; i <= CarroUtil.cant_car; i++)
            {
                if (CarroUtil.carros[i - 1].PrecioAlquiler <= ClienteUtil.clientes[Contratante_n - 1].PagoMaximo)
                {
                    Console.WriteLine($"Carro numero {i}");
                    Console.WriteLine($"\tPlaca: {CarroUtil.carros[i - 1].Placa}\n\tMarca: {CarroUtil.carros[i - 1].Marca}\n\tPrecio de alquiler: {CarroUtil.carros[i - 1].PrecioAlquiler}");
                }
                else;
            }
            Console.WriteLine("");
            Console.WriteLine("Precione cualquier tecla para continuar...");
            Console.ReadKey();
        }
        public static (int, Alquiler[]) Eliminar()
        {
            Console.Clear();
            Console.WriteLine("Que alquiler desea eliminar?");
            Console.WriteLine("Inserte el numero segun lista del alquiler que desea eliminar:");
            alq_elim_n = int.Parse(Console.ReadLine());
            Console.WriteLine("Vuelva a insertar el numero para confirmar:");
            alq_elim_n_c = int.Parse(Console.ReadLine());
            if (alq_elim_n == alq_elim_n_c)
            {
                alq_elim_n--;
                for (int i = 1, j = 0; i < cant_alq && j < cant_alq - 1; i++, j++)
                {
                    alquileres[alq_elim_n + j] = alquileres[alq_elim_n + i];
                }
                cant_alq--;
                Console.WriteLine("Alquiler eliminado con exito...");
                Console.WriteLine("Precione cualquier tecla para continuar...");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("No se ha confirmado la orden de eliminacion...");
                Console.WriteLine("Precione cualquier tecla para continuar...");
                Console.ReadKey();
            }
            return (cant_alq, alquileres);
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
