using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EF_PROYECT
{
    public class CarroUtil
    {
        public static Carro[] carros = new Carro[100];
        public static Carro car = new Carro();
        public static Random r = new Random();
        public static int cant_car = 0;
        public static int car_elim_n = 0;
        public static int car_elim_n_c = 0;
        public static (int, Carro[]) Crear()
        {
            cant_car++;
            carros[cant_car - 1] = new Carro
            {
                Placa = "ABC" + r.Next(1000, 9999).ToString(),
                Marca = "Marca" + r.Next(1, 6).ToString(),
                PrecioAlquiler = r.NextDouble() * (1000 - 100) + 100
            };
            Console.Clear();
            Console.WriteLine("Carro creado con éxito:");
            Console.WriteLine("Inserte placa del vehículo:");
            car.Placa = Console.ReadLine();
            Console.WriteLine("Inserte marca del vehículo:");
            car.Marca=Console.ReadLine();
            Console.WriteLine("Inserte precio de alquiler del vehículo:");
            car.PrecioAlquiler=double.Parse(Console.ReadLine());
            carros[cant_car - 1].Placa = car.Placa;
            carros[cant_car - 1].Marca = car.Marca;
            carros[cant_car - 1].PrecioAlquiler = car.PrecioAlquiler;
            Console.WriteLine($"Cantidad de carros: {cant_car}");
            Console.WriteLine("Precione cualquier tecla para continuar...");
            Console.ReadKey();
            return (cant_car, carros);
        }
        public static void Listar()
        {
            Console.Clear();
            for (int i = 0; i <= cant_car - 1; i++)
            {
                Console.WriteLine($"{i+1}° carro:");
                Console.WriteLine($"{carros[i].ToString()}");
            }
            Console.WriteLine("Precione cualquier tecla para continuar...");
            Console.ReadKey();
        }
        public static (int, Carro[]) Eliminar()
        {
            Console.Clear();
            Console.WriteLine("Que carro desea eliminar?");
            Console.WriteLine("Inserte el numero segun lista del auto que desea eliminar:");
            car_elim_n = int.Parse(Console.ReadLine());
            Console.WriteLine("Vuelva a insertar el numero para confirmar:");
            car_elim_n_c = int.Parse(Console.ReadLine());
            if (car_elim_n == car_elim_n_c)
            {
                car_elim_n--;
                for (int i=1, j=0; i < cant_car && j < cant_car-1; i++, j++)
                {
                    carros[car_elim_n + j] = carros[car_elim_n + i];
                }
                cant_car--;
                Console.WriteLine("Carro eliminado con exito...");
                Console.WriteLine($"Cantidad de carros: {cant_car}");
                Console.WriteLine("Precione cualquier tecla para continuar...");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("No se ha confirmado la orden de eliminacion...");
                Console.WriteLine("Precione cualquier tecla para continuar...");
                Console.ReadKey();
            }
            return (cant_car, carros);
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
