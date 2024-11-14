using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HotelDatabase
{
    public class Facility
    {
        public int FacilityNo { get; set; }

        public int FacilityId { get; set; }

        public string Name { get; set; }

        public override string ToString()
        {
            return $"ID: {FacilityId}, FacilityNo: {FacilityNo}, Name: {Name}";

        }
    }
}
