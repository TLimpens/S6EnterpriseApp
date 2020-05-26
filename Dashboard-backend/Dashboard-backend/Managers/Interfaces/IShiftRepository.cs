﻿using Dashboard_backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dashboard_backend.Managers.Interfaces
{
    public interface IShiftRepository
    {
        Task<Shift> GetShiftAsync(int shiftId);

        List<Shift> GetShifts();

    }
}