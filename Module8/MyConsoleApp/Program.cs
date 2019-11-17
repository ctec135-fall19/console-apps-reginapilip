using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp
{
    class Program
    {
        #region Assignment Specs & Info
        /*
        Prob1: Write a program that test the length of an args array
               Test program by entering several commands via 
               development environment and also through cmd.exe
         */
        #endregion
        static void Main(string[] args)
        {
            #region Prob1
            Console.WriteLine("*** PROBLEM 1 ***\n");
            // tests the length of the args array. If the length is zero,
            // output a message to that affect
            if (args.Length == 0)
            {
                Console.WriteLine("No arguments");
            }
            // if the length is greater than zero, output each argument on a
            // separate line in the form of:
            // -> command: <command line argument>
            else
            {
                foreach(string s in args)
                {
                    Console.WriteLine("-> command: {0}", s);
                }
            }
            #endregion

            Console.WriteLine("\n\n");
        }
    }
}
