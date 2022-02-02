using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class About : BaseEntity
    {
        public int imageID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        
    }
}
