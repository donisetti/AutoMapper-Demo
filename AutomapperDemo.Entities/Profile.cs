using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomapperDemo.Entities
{
    public class Profile
    {
        public Profile()
        {
            
        }

        public long ProfileID { get; set; }
        public string Name { get; set; }
        public string CompanyName { get; set; }
        public DateTime? CreatedOn { get; set; }
        public virtual List<Contact> Contacts { get; set; }

    }
}
