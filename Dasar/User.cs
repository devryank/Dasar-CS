using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dasar
{
    public class User
    {
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

        public override bool Equals(object obj)
        {
            if(FullName == ((User) obj).FullName)
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return FullName;
        }

        public override int GetHashCode()
        {
            return FullName.GetHashCode();
        }

        public string Output()
        {
            return "My name is " + FullName;
        }
        public string Output(int times)
        {
            string message = "";
            for(int i = 0; i < times;  i++)
            {
                message += FirstName + " " + LastName  +  "\n";
            }
            return message;
        }
        
        public static void PrintUsers(List<User> users)
        {
            foreach (User user in users)
            {
                Console.WriteLine(user.ToString());
            }
                    
        }
        public static void PrintUser(User user)
        {
            Console.WriteLine("Static metehod, print user");
            Console.WriteLine(user.ToString());
        }

        public static int Find(List<User> users, string fullName)
        {
            for(int i = 0; i < users.Count;i++) 
            {
                if (users[i].FullName == fullName)
                {
                    return i;
                }
            }
            return -1;
        }

        public static int Find(List<User> users, User user)
        {
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].Equals(user))
                {
                    return i;
                }
            }
            return -1;
        }
        public static User GetUserFromList(List<User> users, User user)
        {
            foreach(User u in users)
            {
                if(u.Equals(user))
                {
                    return u;
                }
            }
            return null;
        }
    }
}
