using Dashboard_backend.Managers.Context;
using Dashboard_backend.Managers.Interfaces;
using Dashboard_backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dashboard_backend.Managers
{
    public class ShiftRepository : IShiftRepository
    {
        private readonly IShiftContext _shiftContext;

        public ShiftRepository(IShiftContext shiftContext)
        {
            _shiftContext = shiftContext;
        }

        public Task<Shift> GetShiftAsync(int shiftId)
        {
            return _shiftContext.GetShiftAsync(shiftId);
        }

        public List<Shift> GetShifts()
        {
            throw new NotImplementedException();
        }
    }
}
