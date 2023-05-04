using Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class RegistrarEscogidos : Repositorio
    {
        public RegistrarEscogidos():base()
        {
            Ruta = "Cafe_Escogido.txt";
        }
        public string Guardar(Empleado_Escogidos cafe)
        {
            try
            {
                StreamWriter w = new StreamWriter(Ruta, true);
                w.WriteLine(cafe.ToString());
                w.Close();
                return "Empleado Guardado Correctamente";
            }
            catch (Exception)
            {

                return "No se Guardo";
            }
        }
        public List<Empleado_Escogidos> GetAll()
        {
            StreamReader reader;
            try
            {
                List<Empleado_Escogidos> registros = new List<Empleado_Escogidos>();
                 reader = new StreamReader(Ruta);
                string FilePath = Ruta;
                while (!reader.EndOfStream)
                {
                    registros.Add(Mappear(reader.ReadLine()));
                }
                reader.Close();
                return registros;
                
            }
            catch(Exception) { return null; }
            finally { reader=null; }
        }
        Empleado_Escogidos Mappear(string lineadatos)
        {
            Empleado_Escogidos registrado = new Empleado_Escogidos();
            registrado.Cc_empleado = lineadatos.Split(';')[0];
            registrado.FechaEscogido = DateTime.Parse(lineadatos.Split(';')[1]);
            //  string f = registrado.FechaEscogido.ToString("dd/MM/yyyy");
            // f = lineadatos.Split(';')[1];
            registrado.cantidad = float.Parse(lineadatos.Split(';')[2]);
            return registrado;
        }

        public string Actualizar(List<Empleado_Escogidos> registrados, bool modo)
        {
            StreamWriter writer = new StreamWriter(Ruta);
            foreach (var item in registrados)
            {
                writer.WriteLine(item.ToString());
            }
            writer.Close();
            return "Se actualizo";
        }
    }
}
