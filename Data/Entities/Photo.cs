using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Photo:BaseEntity
    {

        public string Name { get; set; }

        public string ImagePath { get; set; }

        public DateTime CreationDate { get; set; }
    }
}
