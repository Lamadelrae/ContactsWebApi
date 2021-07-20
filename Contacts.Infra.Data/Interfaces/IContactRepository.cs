using Contacts.Domain.Models.Contacts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts.Infra.Data.Interfaces
{
    public interface IContactRepository : IBaseRepository<Contact> { }
}
