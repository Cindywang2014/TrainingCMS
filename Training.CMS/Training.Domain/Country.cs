using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Domain
{
    public class Country
    {
        public Country()
        {
        
        }
        /// <summary>
        /// Country's id;
        /// </summary>
        public int Id { get;set;}
        /// <summary>
        /// Country's name
        /// </summary>
        public string CountryName { get; set; }
    }
}
