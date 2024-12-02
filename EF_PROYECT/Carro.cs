using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_PROYECT
{
    public class Carro
    {
        public double PrecioAlquiler { get; set; }
        public string Placa { get; set; }
        public string Marca { get; set; }
        public override string? ToString()
        {
            return $"\tPlaca: {Placa}\n\tMarca: {Marca}\n\tPrecio de alquiler: {PrecioAlquiler}";
        }
    }
}
