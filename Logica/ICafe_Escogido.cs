using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Logica
{
    public class ICafe_Escogido : Iservice<Empleado_Escogidos>
    {
        List<Empleado_Escogidos> r;
        RegistrarEscogidos repositorio = new RegistrarEscogidos();
        public ICafe_Escogido()
        {
            Refresh();
        }

        public string Add(Empleado_Escogidos entity)
        {

    

            try
            {
                string Guardado = repositorio.Guardar(entity);
                Refresh();
                return Guardado;
            }
            catch (Exception)
            {

                return "No se pudo Guardar";
            }
        }

        public string delete(Empleado_Escogidos entity)
        {
            try
            {
                r.Remove(entity);
                repositorio.Actualizar(r, false);
                return "se elimino";
            }
            catch (Exception e)
            {

                return e.Message;
            }
        }

        public void Refresh()
        {
            r=repositorio.GetAll();
        }
        public string Edit(Empleado_Escogidos entity)
        {
            throw new NotImplementedException();
        }

        public List<Empleado_Escogidos> GetAll()
        {
            Refresh();
            return r;
        }
    }
}
