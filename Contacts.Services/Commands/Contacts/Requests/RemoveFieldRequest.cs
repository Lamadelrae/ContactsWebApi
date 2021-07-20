using Contacts.Services.Commands.Contacts.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts.Services.Commands.Contacts.Requests
{
    public class RemoveFieldRequest : IRequest<RemoveFieldResponse>
    {
        public Guid Id { get; set; }
    }
}
