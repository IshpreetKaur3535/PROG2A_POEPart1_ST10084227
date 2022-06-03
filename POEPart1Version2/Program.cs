using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace POEPart1Version2
{
    
    class Program
    {
        //declared the delegate method
        public delegate string messageDelegate(string userName);
        static void Main(string[] args)
        {
            
            displayOutput displayResult = new displayOutput(); // created an object of the class displayOutput
           
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.White; // setting the text colour 
                Console.BackgroundColor = ConsoleColor.Blue; // setting the background colour of the text

                Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<<<<<<WELCOME TO THE BUDGETING APPLICATION>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");

                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;

                Console.WriteLine("===================================================================================================");
                // the use of try catch is to handle the wrong inputs
              
                    messageDelegate md = userName => //lambda method 
                    {
                        Console.Write("Please enter your Name>>>");
                        userName = Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine("Welcome to the application " + userName + " now you can use our BUDGETING APPLICATION to do the calculations");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("--------------------------------------------------------------------------------------------------------");
                        return userName;
                    };
                    md.Invoke(""); //print outs
                    displayResult.Result();// calling a mehtod result() from displayOutput class which display the main output of the application
                    Console.WriteLine("Do you want to use the app again?" +
                        "\n(please enter 1 to resume or any other key to close the app)");
                    string value = null;
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
