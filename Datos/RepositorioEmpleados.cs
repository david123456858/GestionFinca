using Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class RepositorioEmpleados:Repositorio
    {
        public RepositorioEmpleados():base() {
            Ruta = "Empleados.txt";
        }

        public string Guardar(Empleado empleado)
        {
            try
            {
                StreamWriter w = new StreamWriter(Ruta, true);
                w.WriteLine(empleado.ToString());
                w.Close();
                return "Empleado Guardado Correctamente";
            }
            catch (Exception)
            {

                return "No se Guardo";
            }
        }
        public List<Empleado> GetAll()
        {
            StreamReader reader;
            try
            {
                List<Empleado> empleados = new List<Empleado>();
                 reader = new StreamReader(Ruta);
                string FilePath = Ruta;
                while (!reader.EndOfStream)
                {
                    empleados.Add(Mappear(reader.ReadLine()));
                }
                reader.Close();
                return empleados;
            }
            catch (Exception)
            {
                return null;
            }
            finally { reader=null; }
        }
        Empleado Mappear (string lineadatos)
        {
            Empleado empleado = new Empleado();
            empleado.CC = lineadatos.Split(';')[0];
            empleado.name_1 = lineadatos.Split(';')[1];
            empleado.name_2 = lineadatos.Split(';')[2];
            empleado.apellido_1 = lineadatos.Split(';')[3];
            empleado.apellido_2 = lineadatos.Split(';')[4];
            empleado.edad = lineadatos.Split(';')[5];
            empleado.FechaInicio = DateTime.Parse(lineadatos.Split(';')[6]);
            //string f = empleado.FechaInicio.ToString("dd/MM/yyyy");
            //f = lineadatos.Split(';')[6];
            return empleado;
        }
       
        public string Actualizar(List<Empleado> empleados,bool modo)
        {
            StreamWriter writer = new StreamWriter(Ruta);
            foreach (var item in empleados)
            {
                writer.WriteLine(item.ToString());
            }
            writer.Close();
            return "Se actualizo";
        }
    }
}
