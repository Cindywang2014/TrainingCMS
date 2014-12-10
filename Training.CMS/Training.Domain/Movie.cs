using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Domain
{
    public class Movie
    {
        public Movie()
        {

        }

        public int Id { get; set; }
        /// <summary>
        /// this is foreign key of MovieType
        /// </summary>
        public int MovieTypeId { get; set; }

        public string MovieName { get; set; }

        public string Description { get; set; }

        public string Actor { get; set; }

        public string Image { get; set; }

        public DateTime UploadDate { get; set; }

        public bool IsAudit { get; set; }

        
    }

}
