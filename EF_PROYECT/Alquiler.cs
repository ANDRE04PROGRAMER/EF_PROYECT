using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EF_PROYECT
{
    public class Alquiler
    {
        public int Numero { get; set; }
        public Carro CarroAlq { get; set; }
        public Cliente Contratante { get; set; }
        public double Precio { get; set; }
        public override string? ToString()
        {
            return $"\tNumero de alquiler: {Numero}\n\tNumero de carro: {AlquilerUtil.CarroAlq_n}\n\tCaracteristicas del carro:\n\t\tPlaca: {CarroAlq.Placa}\n\t\tMarca: {CarroAlq.Marca}\n\t\tPrecio de alquiler: {CarroAlq.PrecioAlquiler}\n\tNumero de cliente: {AlquilerUtil.Contratante_n}\n\tCaracteristicas del contratante:\n\t\tDNI: {Contratante.Dni}\n\t\tNombre: {Contratante.Nombre}\n\t\tPago maximo: {Contratante.PagoMaximo}\n\tPrecio del alquiler: {Precio}";
        }
    }
}