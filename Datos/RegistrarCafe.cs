using Entidades;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class RegistrarCafe:Repositorio
    {
        public RegistrarCafe()
        {
            Ruta = "Cafe.txt";
        }
        public string Guardar(Registrado_Cafe cafe)
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
        public List<Registrado_Cafe> GetAll()
        {

            StreamReader reader;
            try
            {

                List<Registrado_Cafe> registros = new List<Registrado_Cafe>();
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

            finally { reader = null; }
            
        }
        Registrado_Cafe Mappear(string lineadatos)
        {
            Registrado_Cafe registrado = new Registrado_Cafe();
            registrado.Kilos_cereza = float.Parse(lineadatos.Split(';')[0]);
            registrado.Kilos_secos = float.Parse(lineadatos.Split(';')[1]);
            registrado.Fecha = DateTime.Parse(lineadatos.Split(';')[2]);
            // string f = registrado.Fecha.ToString("dd/MM/yyyy");
            //f = lineadatos.Split(';')[2];

            return registrado;
        }

        public string Actualizar(List<Registrado_Cafe> registrados, bool modo)
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
