using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HourRegistrationService.Controllers
{

    [Route("hours")]
    public class HourController : Controller
    {

        [HttpGet("GetHours")]
        public string get()
        {
            return "This is the Hour registration service service";
        }

    }
}