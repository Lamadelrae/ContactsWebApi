using Contacts.Domain.Models.Contacts;
using Contacts.Infra.Data.Interfaces;
using Contacts.Services.Commands.Contacts.Requests;
using Contacts.Services.Commands.Contacts.Responses;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Contacts.Services.Commands.Contacts.Handlers
{
    public class ContactHandler : IRequestHandler<CreateContactRequest, CreateContactResponse>,
                                  IRequestHandler<UpdateContactRequest, UpdateContactResponse>,
                                  IRequestHandler<RemoveContactRequest, RemoveContactResponse>
    {
        readonly IContactRepository _contactRepository;

        public ContactHandler(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }

        public async Task<CreateContactResponse> Handle(CreateContactRequest request, CancellationToken cancellationToken)
        {
            Contact contact = _contactRepository.Insert(new Contact(request.Name));

            return new CreateContactResponse
            {
                Id = contact.Id,
                Name = contact.Name
            };
        }

        public async Task<UpdateContactResponse> Handle(UpdateContactRequest request, CancellationToken cancellationToken)
        {
            Contact contact = _contactRepository.Update(new Contact(request.Id, request.Name));

            return new UpdateContactResponse
            {
                Id = contact.Id,
                Name = contact.Name
            };
        }

        public async Task<RemoveContactResponse> Handle(RemoveContactRequest request, CancellationToken cancellationToken)
        {
            _contactRepository.Delete(request.Id);

            return new RemoveContactResponse
            {
                Id = request.Id
            };
        }
    }
}
