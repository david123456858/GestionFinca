using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pedidos
    {
        public string Id_pedido { get; set; }
        public string CC_Empleado { get; set; }
        public string Nombre_pedido { get; set; }
        public decimal costo { get; set; }
        public DateTime Fecha { get; set; }

        public override string ToString()
        {
            return string.Format(Id_pedido + ";"+CC_Empleado + ";"+Nombre_pedido + ";"+costo + ";"+Fecha);
        }
    }
}
