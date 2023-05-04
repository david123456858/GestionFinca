using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class IEmpleados : Iservice<Empleado>
    {
        List<Empleado> r;
        RepositorioEmpleados repositorio = new RepositorioEmpleados();
        public IEmpleados()
        {
            Refresh();
        }
        public string Add(Empleado entity)
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

        public string delete(Empleado entity)
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
            r = repositorio.GetAll();
        }
        public string Edit(Empleado entity)
        {
            throw new NotImplementedException();
        }

        public List<Empleado> GetAll()
        {
            Refresh();
            return r;
        }
    }
}
