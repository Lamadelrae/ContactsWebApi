using Contacts.Domain.Models.Contacts;
using Contacts.Infra.Data.Interfaces;
using Contacts.Services.Queries.Contacts.DTO;
using Contacts.Services.Queries.Contacts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts.Services.Queries.Contacts.Handlers
{
    public class ContactFieldQuery : IContactFieldQuery
    {
        IContactFieldRepository _contactFieldRepository;

        public ContactFieldQuery(IContactFieldRepository contactFieldRepository) => _contactFieldRepository = contactFieldRepository;

        public ContactFieldDto Get(Guid id)
        {
            ContactField field = _contactFieldRepository.Get(id);
            return new ContactFieldDto
            {
                Type = field.Type.ToString(),
                Value = field.Value
            };
        }

        public IEnumerable<ContactFieldDto> Get()
        {
            return _contactFieldRepository.Get()
                .Select(i => new ContactFieldDto
                {
                    Type = i.Type.ToString(),
                    Value = i.Value
                });
        }
    }
}
