using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POEPart1Version2
{
    class HomeLoan : Expenses // inherits the abstract class -->expenses 
    {
        // variables to store home loan values
        public static float priceOfProperty { get; set; }
        public static  float totalDeposit { get; set; }
        public static float interestRate { get; set; }
        public static float monthsToRepay { get; set; }
        public static float HomeLoanRepayment { get; set; }



        //method which will ask user to input the values for the home loan 
        public override void inputValues()
        {
            Console.WriteLine("---------------------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Please Enter the following values for a home loan");

            //used try catch to handle the wrong inputs 
            Console.Write("Please enter the Purchase price of property:");
            try
            {
                priceOfProperty = float.Parse(Console.ReadLine());
            }catch
            {
                Console.WriteLine("Please Enter a valid numerical value!");
                Console.Write("Please enter the Purchase price of property:");
                priceOfProperty = float.Parse(Console.ReadLine());
            }

            Console.Write("Please enter the Total deposit:");
            try
            {
                
                totalDeposit = float.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Please Enter a valid numerical value!");
                Console.Write("Please enter the Total deposit:");
                totalDeposit = float.Parse(Console.ReadLine());
            }

            Console.Write("Please enter the Interest rate (percentage):");
            try
            {
                interestRate = float.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Please Enter a valid numerical value!");
                Console.Write("Please enter the Interest rate (percentage):");
                interestRate = float.Parse(Console.ReadLine());
            }

            while (true)
            {
                
                Console.Write("Number of months to repay (between 240 and 360): ");
                try
                {
                    monthsToRepay = float.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Please Enter a valid numerical value!");
                    Console.Write("Number of months to repay (between 240 and 360): ");
                    monthsToRepay = float.Parse(Console.ReadLine());
                }
                if (monthsToRepay >= 240 && monthsToRepay <= 360) // uses if statement to manage the numbers of months to repay
                {
                    break;
                }
            }

            Console.WriteLine("----------------------------------------------------------------------------------------");

           

        }
        // method to display the home loan values in a formatted way 
        public void displayValues()
        {
            Console.WriteLine("Values of a Home Loan are: " +
                "\n\t\ta. Purchase Price of the Property:\t\t\tR" + priceOfProperty +
                "\n\t\tb. Total Deposit:\t\t\t\t\tR" + totalDeposit +
                "\n\t\tc. Interest rate (percentage):\t\t\t\t" + interestRate + "%" +
                "\n\t\td. Number of months to repay(Between 240 and 360):\t" + monthsToRepay + " months" +                     
                "\n");

        }


        //method to check whether the home loan approval is likely or not 
        public void homeLoanLikelyORUnlikely() {
            if (HomeLoan.HomeLoanRepayment > monthlyGrossIncome / 3)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine("Approval of the home loan is unlikely");
            }
            else
                Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("Approval of the home loan is likely");
            expensesList[6] = HomeLoan.HomeLoanRepayment; // store monthly home loan repayment value into array
            
        }


        // return method which calculate the monthly home loan repayment and display the monthly home loan repayment 
        public float homeLoanCalculation()
        {
            HomeLoanRepayment = HomeLoan.emiCalculation(priceOfProperty - totalDeposit, interestRate, monthsToRepay / 12);
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Monthly home loan repayment for buying a property:  {0:C} " , HomeLoanRepayment);
            Console.BackgroundColor = ConsoleColor.Black;
            
            return HomeLoanRepayment;
        }

    }
}
