using Contacts.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts.Infra.Data.Interfaces
{
    public interface IBaseRepository<T> where T : Entity
    {
        IEnumerable<T> Get();

        T Get(Guid id);

        T Insert(T obj);

        T Update(T obj);

        void Delete(Guid id);
    }
}
