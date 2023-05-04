using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empleado:Persona
    {
        public DateTime FechaInicio { get; set; }

        public override string ToString()
        {
            return string.Format(CC + ";" + name_1 + ";" + name_2 + ";" + apellido_1 + ";" + apellido_2 + ";" + edad + ";" + FechaInicio.ToShortDateString());
        }
    }
}
