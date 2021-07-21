using Contacts.Services.Commands.Contacts.Requests;
using Contacts.Services.Queries.Contacts.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Contacts.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContactFieldController : ControllerBase
    {
        readonly IContactFieldQuery _contactFieldQuery;
        readonly IMediator _mediator;

        public ContactFieldController(IContactFieldQuery contactFieldQuery, IMediator mediator)
        {
            _contactFieldQuery = contactFieldQuery;
            _mediator = mediator;
        }

        [HttpGet]
        public IActionResult Get(Guid id) => new ApiHelper().TryCatchFunc(() => _contactFieldQuery.Get(id));

        [HttpGet]
        public IActionResult Get() => new ApiHelper().TryCatchFunc(() => _contactFieldQuery.Get());

        [HttpPost]
        public IActionResult Post([FromBody] CreateFieldRequest obj) => new ApiHelper().TryCatchAction(() => _mediator.Send(obj));

        [HttpPut]
        public IActionResult Put([FromBody] UpdateFieldRequest obj) => new ApiHelper().TryCatchAction(() => _mediator.Send(obj));

        [HttpDelete]
        public IActionResult Delete(Guid id) => new ApiHelper().TryCatchAction(() => _mediator.Send(new RemoveFieldRequest() { Id = id }));
    }
}