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
    public class RepositorioVentas : Repositorio
    {
        public RepositorioVentas():base()
        {
            Ruta = "Ventas.txt";
        }
        public string Guardar(Registro_Ventas venta)
        {
            try
            {
                StreamWriter w = new StreamWriter(Ruta, true);
                w.WriteLine(venta.ToString());
                w.Close();
                return "Empleado Guardado Correctamente";
            }
            catch (Exception)
            {

                return "No se Guardo";
            }
        }
        public List<Registro_Ventas> GetAll()
        {
            StreamReader reader;
            try
            {
                List<Registro_Ventas> ventas = new List<Registro_Ventas>();
                 reader = new StreamReader(Ruta);
                string FilePath = Ruta;
                while (!reader.EndOfStream)
                {
                    ventas.Add(Mappear(reader.ReadLine()));
                }
                reader.Close();
                return ventas;
            }

            catch (Exception)
            {
                return null;
            }
            finally { reader = null; }
        }
        Registro_Ventas Mappear(string lineadatos)
        {
            Registro_Ventas venta = new Registro_Ventas();
            venta.Id_ventas = lineadatos.Split(';')[0];
            venta.Kilos = float.Parse(lineadatos.Split(';')[1]);
            venta.Valor_Kilo= float.Parse(lineadatos.Split(';')[2]);
            venta.Factor = lineadatos.Split(';')[3];
            venta.Fecha = DateTime.Parse(lineadatos.Split(';')[4]);
            // string f = venta.Fecha.ToString("dd/MM/yyyy");
            //f = lineadatos.Split(';')[4];
            venta.Total = decimal.Parse(lineadatos.Split(';')[5]);
            return venta;
        }

        public string Actualizar(List<Registro_Ventas> ventas, bool modo)
        {
            StreamWriter writer = new StreamWriter(Ruta);
            foreach (var item in ventas)
            {
                writer.WriteLine(item.ToString());
            }
            writer.Close();
            return "Se actualizo";
        }

    }
}
