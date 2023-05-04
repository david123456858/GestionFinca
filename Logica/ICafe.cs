using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ICafe : Iservice<Registrado_Cafe>
    {
        List<Registrado_Cafe> r;
        RegistrarCafe repositorio = new RegistrarCafe();

        public ICafe()
        {
            Refresh();
        }
        public string Add(Registrado_Cafe entity)
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

        public string delete(Registrado_Cafe entity)
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

        public string Edit(Registrado_Cafe entity)
        {
            throw new NotImplementedException();
        }

        public List<Registrado_Cafe> GetAll()
        {
            Refresh();
            return r;
        }
    }
}
