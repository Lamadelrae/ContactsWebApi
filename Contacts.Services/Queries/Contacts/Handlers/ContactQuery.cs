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
    public class ContactQuery : IContactQuery
    {
        IContactRepository _contactRepository;

        public ContactQuery(IContactRepository contactRepository) => _contactRepository = contactRepository;

        public ContactDto Get(Guid id)
        {
            Contact contact = _contactRepository.Get(id);

            return new ContactDto
            {
                Id = contact.Id,
                Name = contact.Name
            };
        }

        public IEnumerable<ContactDto> Get()
        {
            return _contactRepository.Get()
                .Select(i => new ContactDto
                {
                    Id = i.Id,
                    Name = i.Name
                });
        }
    }
}
