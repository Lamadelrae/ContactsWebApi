using Contacts.Services.Commands.Contacts.Responses;
using MediatR;
using System;

namespace Contacts.Services.Commands.Contacts.Requests
{
    public class UpdateContactRequest : IRequest<UpdateContactResponse>
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
    }
}