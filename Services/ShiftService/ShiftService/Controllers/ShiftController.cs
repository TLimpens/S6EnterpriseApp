﻿ using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShiftService.Models;

namespace ShiftService.Controllers
{
    [Route("api/[controller]")]
    public class ShiftController : Controller
    {
        [HttpGet("GetShift/{id}")]
        public Shift GetShift(int id)
        {
            return new Shift(1, 4, DateTime.Now, new List<User>() { new User(id, "david") });
        }

        [HttpGet("GetShifts/{id}")]
        public List<Shift> GetShifts()
        {
            return new List<Shift>() { new Shift(1, 4, DateTime.Now, null) };
        }
    }
}