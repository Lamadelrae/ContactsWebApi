using Contacts.Domain.Models.Contacts;
using Contacts.Infra.Data.Interfaces;
using Contacts.Services.Commands.Contacts.Requests;
using Contacts.Services.Commands.Contacts.Responses;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Contacts.Services.Commands.Contacts.Handlers
{
    public class ContactFieldHandler : IRequestHandler<CreateFieldRequest, CreateFieldResponse>,
                                       IRequestHandler<UpdateFieldRequest, UpdateFieldResponse>,
                                       IRequestHandler<RemoveFieldRequest, RemoveFieldResponse>
    {
        readonly IContactFieldRepository _contactFieldRepository;

        public ContactFieldHandler(IContactFieldRepository contactFieldRepository)
        {
            _contactFieldRepository = contactFieldRepository;
        }

        public async Task<CreateFieldResponse> Handle(CreateFieldRequest request, CancellationToken cancellationToken)
        {
            ContactField field = _contactFieldRepository.Insert(new ContactField(request.ContactId, (ContactDataType)request.Type, request.Value));

            return new CreateFieldResponse
            {
                ContactId = field.ContactId,
                Type = (int)field.Type,
                Value = field.Value
            };
        }

        public async Task<UpdateFieldResponse> Handle(UpdateFieldRequest request, CancellationToken cancellationToken)
        {
            ContactField field = _contactFieldRepository.Update(new ContactField(request.Id, request.ContactId, (ContactDataType)request.Type, request.Value));

            return new UpdateFieldResponse
            {
                Id = field.Id,
                ContactId = field.ContactId,
                Type = (int)field.Type,
                Value = field.Value
            };
        }

        public async Task<RemoveFieldResponse> Handle(RemoveFieldRequest request, CancellationToken cancellationToken)
        {
            _contactFieldRepository.Delete(request.Id);

            return new RemoveFieldResponse
            {
                Id = request.Id
            };
        }
    }
}
