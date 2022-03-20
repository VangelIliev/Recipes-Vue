using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes_Vue.Domain.Interfaces
{
    public interface IServiceBase<T> where T : IBaseEntity
    {
        List<T> FindAll();
        bool Create(T entity);
        T Read(Guid id);
        bool Update(T entity);
        bool Delete(T entity);
    }
}
