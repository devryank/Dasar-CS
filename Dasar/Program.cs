using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Dasar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.DoSomething();
        }

        public void DoSomething()
        {
            User me = new User();
            me.FirstName = "Ryan";
            me.LastName = "Kurniawan";

            User you = new User();
            you.FirstName = "John";
            you.LastName = "Smith";

            List<User> users = new List<User>() { me, you };

            User search = new User();
            search.FirstName = "John";
            search.LastName = "Smith";
            Console.WriteLine(User.GetUserFromList(users, search));

            if(User.GetUserFromList(users, search) == null)
            {
                Console.WriteLine("Not found");
            }

            User user = new User();
            user.FirstName = "Sally";
            Test(user);
            Console.WriteLine(user.FirstName);
        }

        public void Test(User i)
        {
            i.FirstName = "Samantha";
        }
    }
}
