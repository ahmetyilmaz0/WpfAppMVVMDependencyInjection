using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Services
{
    public interface IServiceBase<T>
    {
        List<T> List();
        bool Add(T entity);
        bool Delete(T entity);
        bool Update(T entity);
    }
}
