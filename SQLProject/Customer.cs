using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLProject
{
    public class Customer
    {
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }

        public string FullInfo
        {
            get
            {
                // some kind of format to return info
                return $"{FirstName} {LastName} ({Phone})";
            }
        }

    }
}
