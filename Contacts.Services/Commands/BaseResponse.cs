using System;

namespace Contacts.Services.Commands
{
    public abstract class BaseResponse
    {
        public string Message { get; set; } = $"Ok! Command made at {DateTime.Now}";
    }
}
