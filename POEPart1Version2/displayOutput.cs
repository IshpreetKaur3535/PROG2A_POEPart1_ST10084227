using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace POEPart1Version2
{
    
    class displayOutput : Expenses // inherits the abstract class --> expenses
    {   
        public static double monthlyRental { get; set; } // variable to store monthly rental values 

        // method which will output the main result of the application
        public  void Result()
        {
          
            HomeLoan homeLoan = new HomeLoan(); // created an object of the HomeLoan class
            UserInput userInput = new UserInput();// created an object of the UserInput class

            userInput.inputValues(); // calling a method inputValues() from UserInput class
            Thread.Sleep(2000); // holds the screen for 2 sec
            userInput.displayValues();// calling a mehtod displayNames() from UserInput class

            string typeAcc;

            while (true)
            {
                Console.WriteLine();
                Thread.Sleep(2000);//holds screen for 2sec
                inputValues();

                typeAcc = (Console.ReadLine());
                if (typeAcc == "1" || typeAcc == "2")
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    break;
                }
            }
            // used switch cases to ask user input based their choice
            // case 1 will ask user input about the rental
            // case 2 will ask user input about buying a property
            switch (typeAcc)
            {
                case "1":
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine("----------------------------------------------------------------------------------------------------------");
                    Console.Write("Please enter the Monthly rental amount: ");
                    try
                    {
                        monthlyRental = double.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Please enter a valid numerical value!");
                        Console.Write("Please enter the Monthly rental amount: ");
                        monthlyRental = double.Parse(Console.ReadLine());
                    }
                    expensesList[6] = monthlyRental; //stores monthly rental values into array
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("The monthly rental is:\tR" + monthlyRental);
                    Console.ForegroundColor = ConsoleColor.White;

                break;
                case "2":
                    homeLoan.inputValues(); // calling a method inputValues() from HomeLoan class
                    Console.WriteLine();
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Green;
                    homeLoan.displayValues(); // calling a method displayMethod() from HomeLoan class
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine("Calculating Monthly Home Loan Repayment. . .");
                    Thread.Sleep(4000); //holds the screen for 4sec
                    homeLoan.homeLoanCalculation(); // calling a method homeLoanCalculation() from HomeLoan class
                    homeLoan.homeLoanLikelyORUnlikely(); // calling a mehtod homeLoanLikelyORUnlikely from HomeLoan class 
                break;
            }

        float availableMoney = 0;
        if (typeAcc == "1")
            {
                availableMoney = (float)(monthlyGrossIncome - (totalExpenseCalculation() + monthlyRental)); // calculate the available money after the total expendictures and monthly rental deductions have been made.
                
            }
            else if (typeAcc == "2")
            {
                availableMoney = (float)(monthlyGrossIncome - (totalExpenseCalculation() + HomeLoan.HomeLoanRepayment)); // calculate the available money after the total expendictures and monthly home loan repayment deductions have been made.
            }
            Console.WriteLine();
            Console.WriteLine("Calculating Available Monthly Money . . .");
            Thread.Sleep(4000); // holds the screen for 4sec
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Available monthly money after all the specified deductions have been made:  {0:C} ", availableMoney); // display the avaible money based on which choice does a user made 
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("----------------------------------------------------------------------------------------------------------");
            Console.WriteLine("==========================================================================================================");
            
        }

        //methos which will ask users to make a choice between renting accommodation or buying a property
        public override void inputValues()
        {
            Console.Write("Do you want to rent accomodation or buy a property? \n(Please type (1) for renting accomodation or (2) for buying a property)"
                   + "\n\t\t1. Renting accommodation"
                   + "\n\t\t2. Buying a property\n");
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.Write("\nYOUR CHOICE IS: ");

        }
    }
}

