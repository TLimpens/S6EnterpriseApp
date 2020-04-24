using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dashboard_backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace Dashboard_backend.Controllers
{
    [Route("api/shifts")]
    [ApiController]
    public class ShiftController : Controller
    {
        [HttpGet]
        [Route("getallshifts")]
        public string GetAllShifts()
        {
            return "Test";
        }

        [HttpGet]
        [Route("getshift/{id}")]
        public Shift GetShift(int id)
        {
           return new Shift(id);
        }
    }

}