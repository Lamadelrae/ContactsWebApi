using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts.Services.Commands.Contacts.Responses
{
    public class RemoveFieldResponse : BaseResponse
    {
        public Guid Id { get; set; }
    }
}
