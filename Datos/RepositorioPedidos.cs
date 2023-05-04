using Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class RepositorioPedidos : Repositorio
    {
        public RepositorioPedidos():base()
        {
            Ruta = "Pedidos.txt";
        }
        public string Guardar(Pedidos pedido)
        {
            try
            {
                StreamWriter w = new StreamWriter(Ruta, true);
                w.WriteLine(pedido.ToString());
                w.Close();
                return "Empleado Guardado Correctamente";
            }
            catch (Exception)
            {

                return "No se Guardo";
            }
        }
        public List<Pedidos> GetAll()
        {

            List<Pedidos> pedidos = new List<Pedidos>();
            StreamReader reader = new StreamReader(Ruta);
            string FilePath = Ruta;
            while (!reader.EndOfStream)
            {
                pedidos.Add(Mappear(reader.ReadLine()));
            }
            reader.Close();
            return pedidos;
        }
       Pedidos Mappear(string lineadatos)
        {
            Pedidos pedidos = new Pedidos();
            pedidos.Id_pedido= lineadatos.Split(';')[0];
            pedidos.CC_Empleado = lineadatos.Split(';')[1];
            pedidos.Nombre_pedido = lineadatos.Split(';')[2];
            pedidos.costo = decimal.Parse(lineadatos.Split(';')[3]);
            string f = pedidos.Fecha.ToString("dd/MM/yyyy");
            f = lineadatos.Split(';')[4];
           
            return pedidos;
        }

        public string Actualizar(List<Pedidos> pedidos, bool modo)
        {
            StreamWriter writer = new StreamWriter(Ruta);
            foreach (var item in pedidos)
            {
                writer.WriteLine(item.ToString());
            }
            writer.Close();
            return "Se actualizo";
        }

    }
}
