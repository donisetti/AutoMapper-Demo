using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomapperDemo.Entities
{
    public class Contact
    {
        public Contact()
        {

        }

        public int ContactID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public int ProfileProfileID { get; set; }

        public virtual Profile Profile { get; set; }
    }
}
