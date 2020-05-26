﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dashboard_backend.Managers;
using Dashboard_backend.Managers.Context;
using Dashboard_backend.Managers.Interfaces;
using Dashboard_backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace Dashboard_backend.Controllers
{
    [Route("api/shifts")]
    [ApiController]
    public class ShiftController : Controller
    {
        private readonly IShiftRepository _shiftRepository;

        public ShiftController(IShiftRepository shiftRepository)
        {
            _shiftRepository = shiftRepository;
        }

        [HttpGet]
        [Route("getallshifts")]
        public string GetAllShifts()
        {
            return "Test";
        }

        [HttpGet]
        [Route("getshift/{id}")]
        public Task<Shift> GetShift(int id)
        {
           return _shiftRepository.GetShiftAsync(id);
        }
    }

}