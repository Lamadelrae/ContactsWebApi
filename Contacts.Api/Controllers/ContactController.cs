using Contacts.Services.Commands.Contacts.Requests;
using Contacts.Services.Queries.Contacts.DTO;
using Contacts.Services.Queries.Contacts.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Contacts.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContactController : ControllerBase
    {
        readonly IContactQuery _contactQuery;
        readonly IMediator _mediator;

        public ContactController(IContactQuery contactQuery, IMediator mediator)
        {
            _contactQuery = contactQuery;
            _mediator = mediator;
        }

        [HttpGet]
        public IActionResult Get(Guid id) => new ApiHelper().TryCatchFunc(() => _contactQuery.Get(id));

        [HttpGet]
        public IActionResult Get() => new ApiHelper().TryCatchFunc(() => _contactQuery.Get());

        [HttpPost]
        public IActionResult Post([FromBody] CreateContactRequest obj) => new ApiHelper().TryCatchAction(() => _mediator.Send(obj));

        [HttpPut]
        public IActionResult Put([FromBody] UpdateContactRequest obj) => new ApiHelper().TryCatchAction(() => _mediator.Send(obj));

        [HttpDelete]
        public IActionResult Delete(Guid id) => new ApiHelper().TryCatchAction(() => _mediator.Send(new RemoveContactRequest() { Id = id }));
    }
}
