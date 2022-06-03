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
            

            Console.Write("Please enter Gross monthly income (before deductions): ");
            try
            {
                income = double.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Please Enter a valid numerical value!");
                Console.Write("Please Enter Gross monthly income (before Deductions):");
                income = double.Parse(Console.ReadLine());
            }



            Console.Write("Please enter Estimated monthly tax deducted: ");
            try
            {
                monthlyTaxDeducted = double.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("\tPlease Enter a valid numerical value!");
                Console.Write("Please enter Estimated monthly tax deducted: ");
                monthlyTaxDeducted = double.Parse(Console.ReadLine());
            }
            //expensesList[0] = monthlyTaxDeducted; // store monthly tax value into array
            //expenses.Add(monthlyTaxDeducted);

            monthlyGrossIncome = income - monthlyTaxDeducted; // calculates the monthly gross income after the tax deduction

            Console.WriteLine("Your monthly income after tax deducte is: R" + monthlyGrossIncome);

            Console.WriteLine("Please enter Estimated monthly expenditures in each of the following categories:");

            Console.Write("\t Groceries: ");
            try
            {
                monthlyGroceries = double.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("\tPlease Enter a valid numerical value!");
                Console.Write("\t Groceries: ");
                monthlyGroceries = double.Parse(Console.ReadLine());
            }
            //expensesList[1] = monthlyGroceries; // store monthly groceries value into array
            expenses.Add(monthlyGroceries); // stores the value of monthly groceries to list

            Console.Write("\t Water and Light: ");
            try
            {
                monthlyWaterLight = double.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("\tPlease Enter a valid numerical value!");
                Console.Write("\t Water and Light: ");
                monthlyWaterLight = double.Parse(Console.ReadLine());
            }
            //expensesList[2] = monthlyWaterLight; // store monthly water and light value into array
            expenses.Add(monthlyWaterLight); // stores the value of monthly water and light cost to list

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
            //expensesList[3] = montlyTravelCost; // store montly travel cost value into array
            expenses.Add(montlyTravelCost); // stores the value of monthly travel cost to list

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
            //expensesList[4] = monthlyCellphoneCost; // store monthly cell phone cost value into array
            expenses.Add(monthlyCellphoneCost); // stores the value of monthly cell phone cost to list
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
            //expensesList[5] = monthlyOtherExpenses; // store monthly other expenses value into array
            expenses.Add(monthlyOtherExpenses); // stores the value of monthly other expenses cost to list
            Console.WriteLine("");
        }
    
        
       
        // methos which will display the gross income and monthly expenditures in a formatted way
        public void displayValues()
        {
            
            Console.WriteLine("---------------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Green; // setting the text colour of display
            
                Console.Write("Gross monthly income (after tax deduction):\tR" + monthlyGrossIncome +
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
