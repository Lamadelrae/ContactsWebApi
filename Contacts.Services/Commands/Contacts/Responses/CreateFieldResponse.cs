using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts.Services.Commands.Contacts.Responses
{
    public class CreateFieldResponse : BaseResponse
    {
        public Guid ContactId { get; set; }

        public int Type { get; set; }

        public string Value { get; set; }
    }
}
