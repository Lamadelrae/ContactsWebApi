using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts.Domain.Models
{
    public abstract class Entity
    {
        public Guid Id { get; private set; }

        public DateTime RegistrationDate { get; private set; }

        public Entity(Guid id, DateTime registrationDate)
        {
            Id = id;
            RegistrationDate = registrationDate;
        }

        public Entity(Guid id)
        {
            Id = id;            
        }
    }
}
