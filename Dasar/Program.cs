﻿using Microsoft.Win32;
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
            me.Verified = true;
            Console.WriteLine(me.FullName);
        }
    }
}
