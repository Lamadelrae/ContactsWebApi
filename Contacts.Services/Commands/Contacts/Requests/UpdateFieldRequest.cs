using Contacts.Services.Commands.Contacts.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts.Services.Commands.Contacts.Requests
{
    public class UpdateFieldRequest : IRequest<UpdateFieldResponse>
    {
        public Guid Id { get; set; }

        public Guid ContactId { get; set; }

        public int Type { get; set; }

        public string Value { get; set; }
    }
}
