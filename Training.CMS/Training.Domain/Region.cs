using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Domain
{
   public class Region
    {
        public Region()
        {

        }
        public int Id { get; set; }
        public int CountryId { get; set; }
        public string RegionName { get; set; }


    }
}
