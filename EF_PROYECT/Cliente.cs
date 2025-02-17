﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_PROYECT
{
    public class Cliente
    {
        public int Dni { get; set; }
        public string Nombre { get; set; }
        public double PagoMaximo { get; set; }
        public override string? ToString()
        {
            return $"\tDNI: {Dni}\n\tNombre: {Nombre}\n\tPago maximo: {PagoMaximo}";
        }
    }
}
