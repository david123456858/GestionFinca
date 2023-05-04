using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public interface Iservice<T>
    {
        string Add(T entity);
        string delete(T entity);
        string Edit (T entity);
        List<T> GetAll();
    }
}
