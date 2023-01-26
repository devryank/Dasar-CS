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
            Student me = new Student();
            me.FirstName = "Jingle";

            Teacher you = new Teacher();
            you.FirstName = "Sally";

            User general = new User();
            general.FirstName = "Ryan";

            List<User> users = new List<User>() { me, you, general };
            foreach(User u in users)
            {
                u.HelloToConsole();
            }
        }
    }
}
