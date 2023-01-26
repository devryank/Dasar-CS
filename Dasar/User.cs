using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dasar
{
    public class User
    {
        public User()
        {
            Console.WriteLine("User being created");
        }
        public User(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public bool Verified { get; set; } = false;
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
        public string FirstName { get;}
        public string LastName { get; }

        public virtual void HelloToConsole()
        {
            Console.WriteLine("Hi, i'm general user, my name is " + FullName);
        } 
    }
}
