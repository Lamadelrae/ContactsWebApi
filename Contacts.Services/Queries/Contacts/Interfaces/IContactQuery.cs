using Contacts.Services.Queries.Contacts.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts.Services.Queries.Contacts.Interfaces
{
    public interface IContactQuery
    {
        public ContactDto Get(Guid id);

        public IEnumerable<ContactDto> Get();
    }
}
