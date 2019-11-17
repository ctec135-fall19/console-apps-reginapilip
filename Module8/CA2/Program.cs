using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA2
{
    class Program
    {

        #region Assignment Specs & Info
        /*
        Prob2: Demonstrate the piping of programs 
         */
        #endregion
        static void Main(string[] args)
        {
            // print program name
            Console.WriteLine("*** Program CA2 ***");
            Console.WriteLine("Enter a  phrase: ");
            // read in a line of input
            string userString = Console.ReadLine();
            // print that line out
            Console.WriteLine(userString);
            Console.WriteLine("\nEntering While Loop");
            // read in/read out for as many lines as you output in CA2
            int i = 0;
            while (i < 5)
            {
                Console.Write("Loop #{0}. Enter a phrase:\n", i+1);
                string userString2 = Console.ReadLine();
                Console.WriteLine("You entered:\n\"{0}\"\n", userString2);
                i++;
            }
            Console.WriteLine();

        }
    }
}
