using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POEPart1Version2
{
    
    class UserInput : Expenses // inherit the abstract class --> expenses 
    {
        //method which will ask user to input the values for monthly gross income and expenditures
        public override void inputValues() 
        {
           
            Console.ForegroundColor = ConsoleColor.White; // setting the text colour 
            Console.BackgroundColor = ConsoleColor.Blue; // setting the background colour of the text

            Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<<<<<<WELCOME TO THE BUDGETING APPLICATION>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
            
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            
            Console.WriteLine("===================================================================================================");
            // the use of try catch is to handle the wrong inputs
            
                Console.Write("Please enter Gross monthly income (before deductions): ");
                try
                {
                    monthlyGrossIncome = double.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Please Enter a valid numerical value!");
                    Console.Write("Please Enter Gross monthly income (before Deductions):");
                    monthlyGrossIncome = double.Parse(Console.ReadLine());
                }



            Console.Write("Please enter Estimated monthly tax deducted: ");
            try
            {
                monthlyTaxDeducted = double.Parse(Console.ReadLine());
            }catch
            {
                Console.WriteLine("\tPlease Enter a valid numerical value!");
                Console.Write("Please enter Estimated monthly tax deducted: ");
                monthlyTaxDeducted = double.Parse(Console.ReadLine());
            }
            expensesList[0] = monthlyTaxDeducted; // store monthly tax value into array

            Console.WriteLine("Please enter Estimated monthly expenditures in each of the following categories:");

            Console.Write("\t Groceries: ");
            try
            {
                monthlyGroceries = double.Parse(Console.ReadLine());
            }catch
            {
                Console.WriteLine("\tPlease Enter a valid numerical value!");
                Console.Write("\t Groceries: ");
                monthlyGroceries = double.Parse(Console.ReadLine());
            }
            expensesList[1] = monthlyGroceries; // store monthly groceries value into array



            Console.Write("\t Water and Light: ");
            try
            {
                monthlyWaterLight = double.Parse(Console.ReadLine());
            }
            catch {
                Console.WriteLine("\tPlease Enter a valid numerical value!");
                Console.Write("\t Water and Light: ");
                monthlyWaterLight = double.Parse(Console.ReadLine());
            }
            expensesList[2] = monthlyWaterLight; // store monthly water and light value into array

            Console.Write("\t Travel costs (including petrol): ");
            try
            {
                montlyTravelCost = double.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("\tPlease Enter a valid numerical value!");
                Console.Write("\t Travel costs (including petrol): ");
                montlyTravelCost = double.Parse(Console.ReadLine());
            }
            expensesList[3] = montlyTravelCost; // store montly travel cost value into array

            Console.Write("\t Cell phone and telephone: ");
            try
            {
                monthlyCellphoneCost = double.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("\tPlease Enter a valid numerical value!");
                Console.Write("\t Cell phone and telephone: ");
                monthlyCellphoneCost = double.Parse(Console.ReadLine());
            }
            expensesList[4] = monthlyCellphoneCost; // store monthly cell phone cost value into array

            Console.Write("\t Other expences: ");
            try
            {
                monthlyOtherExpenses = double.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("\tPlease Enter a valid numerical value!");
                Console.Write("\t Other expences: ");
                monthlyOtherExpenses = double.Parse(Console.ReadLine());
            }
            expensesList[5] = monthlyOtherExpenses; // store monthly other expenses value into array

            Console.WriteLine("");
            }
        // methos which will display the gross income and monthly expenditures in a formatted way
        public void displayValues()
        {

            Console.WriteLine("---------------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Green; // setting the text colour of display
            
                Console.Write("Gross monthly income (before deductions):\tR" + monthlyGrossIncome +
                                    "\nEstimated monthly tax deducted:\t\t\tR" + monthlyTaxDeducted +
                                    "\nEstimated monthly expenditures:" +
                                    "\n\t 1. Groceries:\t\t\t\tR" + monthlyGroceries +
                                    "\n\t 2. Water and lights:\t\t\tR" + monthlyWaterLight +
                                    "\n\t 3. Travel costs (including petrol):\tR" + montlyTravelCost +
                                    "\n\t 4. Cell phone and telephone:\t\tR" + monthlyCellphoneCost +
                                    "\n\t 5. Other expenses:\t\t\tR" + monthlyOtherExpenses);
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("\nTOTAL EXPENSES:\t\t\t\t\tR" + totalExpenseCalculation() + "\n"); // displays the total expenses amount
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("---------------------------------------------------------------------------------");
           
        }


    }
}
