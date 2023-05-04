using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Datos
{
    public class RepositorioAdmin:Repositorio
    {
        
        public RepositorioAdmin()
        {
            Ruta = "Empleados.txt";
        }
        public void Add()
        {

        }
        public List<Empleado> GetAll()
        {
            return new List<Empleado>();
        }
        public Empleado Mappear(string lienadatos)
        {
            Empleado m = new Empleado();
            return m;
        }
        public void Update()
        {

        }
    }
}
