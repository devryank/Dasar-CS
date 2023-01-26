using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dasar
{
    public class User
    {

        public bool Verified { get; set; }
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
            set
            {
            }
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
