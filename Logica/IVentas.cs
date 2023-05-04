using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class IVentas : Iservice<Registro_Ventas>
    {
        RepositorioVentas repositorioVentas = new RepositorioVentas();
        List<Registro_Ventas> ventas;
        public IVentas()
        {
            ventas = repositorioVentas.GetAll();
        }

        public string Add(Registro_Ventas entity)
        {
            

            try
            {
                string Guardado = repositorioVentas.Guardar(entity);
                Refresh();
                return Guardado;
            }
            catch (Exception)
            {

                return "No se pudo Guardar";
            }
        }

        public string delete(Registro_Ventas entity)
        {

            try
            {
                ventas.Remove(entity);
                repositorioVentas.Actualizar(ventas, false);
                return "se elimino";
            }
            catch (Exception e)
            {

                return e.Message;
            }
        }

        public void Refresh()
        {

            ventas = repositorioVentas.GetAll();
        }

        public string Edit(Registro_Ventas venta_new)
        {
            var Venta_actual = GetRegistro_Ventas(venta_new.Id_ventas);

            try
            {
                if (Venta_actual == null)
                {
                    return "Venta no registrada";
                }
                else
                {
                    Venta_actual.Kilos= venta_new.Kilos;
                    Venta_actual.Valor_Kilo = venta_new.Valor_Kilo;
                    Venta_actual.Factor = venta_new.Factor;
                    Venta_actual.Fecha = venta_new.Fecha;
                    Venta_actual.Total= venta_new.Total;
                    

                    repositorioVentas.Actualizar(ventas, false);
                    return "";
                }
                
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Registro_Ventas> GetAll()
        {
            Refresh();
            return ventas;
        }
        public Registro_Ventas GetRegistro_Ventas(string Id_Ventas)
        {
            foreach (var item in ventas)
            {
                if (item.Id_ventas.Equals(Id_Ventas))
                {
                    return item;
                }

            }
            return null;
        }
    }
}
