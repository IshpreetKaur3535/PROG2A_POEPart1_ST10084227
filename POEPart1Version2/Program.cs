using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POEPart1Version2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            displayOutput displayResult = new displayOutput(); // created an object of the class displayOutput
            while (true)
            {
                displayResult.Result();// calling a mehtod result() from displayOutput class which display the main output of the application
                Console.WriteLine("Do you want to use the app again?" +
                    "\n(please enter 1 to resume or any other key to close the app)");
                string value = null ;
                value = Console.ReadLine();
                // if statement to ask users when they want to use the app again or not
                if (value.Equals("1"))
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("Thanku for using the application");
                    break;
                }
            }

            Console.ReadLine();
        }
    }
}
