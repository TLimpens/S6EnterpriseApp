using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dashboard_backend.Models
{
    public class Shift
    {
        public int Id   // property
        { get; set; }

        public Shift(int id)
        {
            Id = id;
        }

        public Shift()
        {
        }

        public override string ToString()
        {
            return base.ToString() + ": " + Id.ToString();
        }

    }
}
