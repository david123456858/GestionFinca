using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Adminservices : Iservice<Empleado>
    {
        List<Empleado> lista = new List<Empleado>();
        public Adminservices() {
        
  
        }
        public string AddCafe()
        {
            return ";";

        }
        public string AddEmpleado()
        {
            return ";";

        }
        public string DeletEmpleado()
        {
            return ";";

        }
        public string editEmpleado()
        {
            return ";";

        }
        public string Add(Empleado entity)
        {
            throw new NotImplementedException();
        }

        public string delete(Empleado entity)
        {
            throw new NotImplementedException();
        }

        public string Edit(Empleado entity)
        {
            throw new NotImplementedException();
        }

        public List<Empleado> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
