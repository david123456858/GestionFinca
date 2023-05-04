using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Nomina
    {
        public string Id_Nomina { get; set; }
        public string CC_Empleado { get; set; }
        public int Pedidos { get; set; }
        public float Kilo_total { get; set; }
        public decimal Total_pagado { get; set; }
        public decimal Valor_base { get; set; }
        public DateTime Fecha_nomina { get; set; }

        public override string ToString()
        {
            return string.Format(Id_Nomina + ";"+CC_Empleado + ";"+Pedidos + ";"+Kilo_total + ";"+Total_pagado + ";"+Valor_base + ";"+Fecha_nomina);
        }
    }
}