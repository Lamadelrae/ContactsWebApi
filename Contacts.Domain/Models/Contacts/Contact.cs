using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts.Domain.Models.Contacts
{
    public class Contact : Entity
    {
        public string Name { get; private set; }

        public Contact(Guid id,
                       string name)
            : base(id)
        {
            Name = name;
        }

        public Contact(string name) 
            : base(Guid.NewGuid(), DateTime.Now)
        {
            Name = name;
        }
    }
}