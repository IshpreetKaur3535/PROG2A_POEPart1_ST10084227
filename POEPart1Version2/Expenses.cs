using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POEPart1Version2
{
    // create an abstrat method
    abstract class Expenses
    {
        // variables to store gross income and expenditures 
        public static double monthlyGrossIncome { get; set; }
        public static double income { get; set; }
        public static double monthlyTaxDeducted { get; set; }
        public static double monthlyGroceries { get; set; }
        public static double monthlyWaterLight { get; set; }
        public static double montlyTravelCost { get; set; }
        public static double monthlyCellphoneCost { get; set; }
        public static double monthlyOtherExpenses { get; set; }
        public static double totalExpenses { get; set; }
        
       
        //created a list to store all the values of expenses
        public static List<double> expenses = new List<double>();
        public abstract void inputValues(); // create an abstract method 

        
        

        /*reference
         GeeksforGeeks.(2021).Program for EMI Calculator. Available at: https://www.geeksforgeeks.org/program-emi-calculator/. [Accessed 10 May 2022]
         */

        // return method to calculate the emi
        public static float emiCalculation(float principalAmount, float interestRate, float t)
        {
            float emi;
            try
            {
                interestRate = interestRate / (12 * 100);
                t = t * 12;
                emi = (principalAmount * interestRate * (float)Math.Pow(1 + interestRate, t)) / (float)(Math.Pow(1 + interestRate, t) - 1);
                return (emi);
            }catch (Exception)
            {
                throw;
            }
        }


        // return method to calculate the totalExpenses
        public double totalExpenseCalculation()
        {
            //totalExpenses = (float)(monthlyTaxDeducted + monthlyGroceries + monthlyWaterLight + montlyTravelCost + monthlyCellphoneCost + monthlyOtherExpenses);
            //totalExpenses = expenses.Aggregate((x, y) => x + y);
            
            totalExpenses = expenses.Sum(); //add all the expenses values
            return totalExpenses;
        }


       
      


    }
}
