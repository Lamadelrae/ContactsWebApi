using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Contacts.Api.Controllers
{
    public class ApiHelper : ControllerBase
    {
        public IActionResult TryCatchAction(Action action)
        {
            try
            {
                action();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        public IActionResult TryCatchFunc<T>(Func<T> func)
        {
            try
            {
                return Ok(func());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
