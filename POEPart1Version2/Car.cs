using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace POEPart1Version2
{
    class Car : Expenses //inherits the abstract class --> Expenses
    {
        // variables to store the values for buying a vehivle
        public static string modelMake { get; set; }
        public static double purchasePrice { get; set; }
        public static double totalDeposit { get; set; }
        public static double interestRate { get; set; }
        public static double estimatedPremium { get; set; }
        public static double CarCost = 0;

        //declared the delegate method globally
        public delegate void notifyUsersDelegate(double totalExp, double income, double house, double car);

        
        //this method asks you to input the values for buying a vehicle
        public override void inputValues() // override the abstrat method
        {
            Console.WriteLine("------------------------------------------------------------------------------------------------");
            Console.WriteLine("Please enter the values for vehicle financing");

            while (true)
            {
                try // use of try catch to handle the expections
                {
                    Console.Write("Please enter the Vehile Model and Make: ");
                    modelMake = Console.ReadLine();

                    Console.Write("Please enter the Purchase price: ");
                    purchasePrice = double.Parse(Console.ReadLine());

                    Console.Write("Please enter the total deposit: ");
                    totalDeposit = double.Parse(Console.ReadLine());

                    Console.Write("Please enter thr interest rate (format 10.5% -> 10,5): ");
                    interestRate = double.Parse(Console.ReadLine());

                    Console.Write("Please enter the estimated insurance premium: ");
                    estimatedPremium = double.Parse(Console.ReadLine());
                }
                catch 
                {
                    Console.WriteLine("Invalid numerical value");
                }
                break;
            }
            
                  
            
        }


        //the displayValues() method display the values of vehicle in a readable format
        public void displayValues()
        {
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Values of Buying a vehicle are as follow: "+
                "\n\t\ta. Model and Make:\t\t\t" + modelMake +
                "\n\t\tb. Purchase Price:\t\t\tR" + purchasePrice +
                "\n\t\tc. Total deposit:\t\t\tR" + totalDeposit +
                "\n\t\td. Interest rate (percentage):\t\t" + interestRate + "%" +
                "\n\t\te. Estimated Insurance Premium:\t\tR" + estimatedPremium);
        }

        //the calcMonthlyCost() method calculates the monthly car cost
        public double calcMonthlyCost ()
        {
            
            double cost = 0;
            double monthlyCost = 0;
            try
            {
                double principalAmount = purchasePrice - totalDeposit; //calculate amount due
                interestRate = interestRate / 100; 

                cost = principalAmount * (1 + (interestRate * 5)); //uses A = P(1 + (1 * n)) formula
                monthlyCost = cost / 60;// gets monthly cost
                monthlyCost += estimatedPremium; //adds insurance permium cost to monthly cost 
                return monthlyCost;
            }
            catch (Exception ex) when (ex is FormatException ||
                              ex is OverflowException)
            {
                return -1;
            }
        }

        //the monthlyCarCost() method display the monthly car cost
        public double monthlyCarCost()
        {
            CarCost = calcMonthlyCost();
            Console.WriteLine("Monthly car cost: R{0}" , CarCost.ToString("F"));
            return CarCost;
        }
       
        //this notifyUsers() method notify the users if the total expenses and loan repayments excced 75% of the user gross income
        public static void notifyUsers(double totalExp, double income, double house, double car)
        {
            double totalexpense = 0;
            totalexpense = totalExp + house + car; // calculate expenses including lonn repayments
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
           //if statement to check whether the expenses are > than 75%  or not
            if ((totalexpense) > (income * 0.75))
            {
                Console.WriteLine("ALERT: Your expenses and loan repayments exceed 75% of your income");
            }
            else 
            {
                Console.WriteLine("Your expenses and loan repayments did not exceed 75% of your income");
            }
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }


        /*this buyCar() method asks the user if they want to buy a vehicle or not,
         if they do want to buy the vehicle then this method will call all the other methods to calculate the monthly cost 
        for buying a vehicle*/
        public void buyCar()
        {
            //instantiate delegate
            notifyUsersDelegate nud = new notifyUsersDelegate(notifyUsers);
            Console.WriteLine("Do you want to buy a vehicle or not?" +
                  "\n(please enter 1 to buy a vehicle or any other key if you do not want to buy)");
            Console.Write("Your Choice: ");
            Console.WriteLine("");
            string value = null;
            value = Console.ReadLine();

            if (value.Equals("1"))
            {
                Thread.Sleep(1000); // thread used to hols the screen
               
                inputValues();
                Thread.Sleep(5000); // holds the screen for 5sec
                displayValues();
                Console.ForegroundColor = ConsoleColor.White; // set the text colour
                Console.BackgroundColor = ConsoleColor.Red; //set the background color
                monthlyCarCost();
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("-----------------------------------------------------------------------");
            }

            // checks that total expenses > 75% of income
            nud(totalExpenses, monthlyGrossIncome, HomeLoan.HomeLoanRepayment, CarCost);
        }
       

        //the displayExpenses() methos displayes the expenses in the descending order
        public static void displayExpenses()
        {
            displayOutput Do = new displayOutput();
           
            Thread.Sleep(500);
            Console.WriteLine("\n-------------------------------------------------------------------" +
                "\n\nExpenses listed: \n");
            int count = 1;

            // foreach to output expenses in descending order
            foreach (double d in expenses.OrderByDescending(d => d))
            {
                Console.WriteLine(count + ": R" + d.ToString("F"));
                count++;
            }
           
            
        }


    }

}
