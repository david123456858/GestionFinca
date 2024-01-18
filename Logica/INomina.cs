using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class INomina : Iservice<Nomina>
    {
        RegistroNominas registro = new RegistroNominas();
        public string Add(Nomina entity)
        {
            var estado = registro.RegistrarNominas(entity);
            return estado;
        }

        public List<Nomina> GetAll(string admin)
        {
            return registro.GetAll(admin);
        }
    }
}
