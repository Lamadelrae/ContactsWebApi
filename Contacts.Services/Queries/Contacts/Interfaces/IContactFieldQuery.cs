using Contacts.Services.Queries.Contacts.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts.Services.Queries.Contacts.Interfaces
{
    public interface IContactFieldQuery
    {
        public ContactFieldDto Get(Guid id);

        public IEnumerable<ContactFieldDto> Get();
    }
}
