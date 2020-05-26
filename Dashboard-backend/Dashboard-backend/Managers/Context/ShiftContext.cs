using Dashboard_backend.Managers.Interfaces;
using Dashboard_backend.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Dashboard_backend.Managers.Context
{
    public class ShiftContext : IShiftContext
    {
        private HttpClient _client;

        public async Task<Shift> GetShiftAsync(int shiftId)
        {
            Shift resultShift = new Shift();
            _client = new HttpClient();
            HttpResponseMessage res = await _client.GetAsync("https://localhost:44391/api/shift/getshift/4");
            if (res.IsSuccessStatusCode) 
            {
                var results = res.Content.ReadAsStringAsync().Result;
                resultShift = JsonConvert.DeserializeObject<Shift>(results);
            
            }

            return resultShift;
        }

        public List<Shift> GetShifts()
        {
            throw new NotImplementedException();
        }
    }
}
