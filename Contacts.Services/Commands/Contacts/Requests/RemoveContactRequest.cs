using Contacts.Services.Commands.Contacts.Responses;
using MediatR;
using System;

namespace Contacts.Services.Commands.Contacts.Requests
{
    public class RemoveContactRequest : IRequest<RemoveContactResponse>
    {
        public Guid Id { get; set; }
    }
}