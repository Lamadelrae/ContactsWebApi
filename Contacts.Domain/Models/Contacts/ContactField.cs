using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts.Domain.Models.Contacts
{
    public class ContactField : Entity
    {
        public Guid ContactId { get; private set; }

        public ContactDataType Type { get; private set; }

        public string Value { get; private set; }

        public ContactField(Guid contactId, 
                            ContactDataType type, 
                            string value)

            : base(Guid.NewGuid(), DateTime.Now)
        {
            ContactId = contactId;
            Type = type;
            Value = value;
        }

        public ContactField(Guid id,
                            Guid contactId,
                            ContactDataType type,
                            string value)
            : base(id)
        {
            ContactId = contactId;
            Type = type;
            Value = value;
        }
    }
}