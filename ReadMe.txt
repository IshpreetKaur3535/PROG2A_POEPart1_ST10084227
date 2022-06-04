THE PERSONAL BUDGETING APPLICATION
*************************************************************************************************************************************************************
Developed by Ishpreet Kaur
*************************************************************************************************************************************************************
Version 4
*************************************************************************************************************************************************************
App config
--------------------------------------------------------------------------------
<?xml version="1.0" encoding="utf-8" ?>
<configuration>
    <startup> 
        <supportedRuntime version="v4.0" sku=".NETFramework,Version=v4.7.2" />
    </startup>
</configuration>
--------------------------------------------------------------------------------
**************************************************************************************************************************************************************
Software Requirement
-------------------------------------------------------------------------------
   --Operating System: Windows 10(32 or 64 bit version), Windows11
   --Processor: Any processor would work
   --RAM: Min 4GB  
-------------------------------------------------------------------------------
**************************************************************************************************************************************************************
Software specs
--------------------------------------------------------------------------------
  --Microsoft Visual Studio 2022
  --Version 17.2
  --Net framework 4.7.2
--------------------------------------------------------------------------------
**************************************************************************************************************************************************************
Project Description
--------------------------------------------------------------------------------------------------------------------
The application will ask for the user to input the monthly gross income, monthly tax 
deducted and monthly expenditures cost. The application will allow user to make a 
choice between renting accommodation or buying a property, if a user chooses
renting accommodation the application will ask user to input monthly rent amount or 
if a user selects to buy a property the application will ask user to input the following 
values (purchase price of property, total deposit, interest rate(percentage), number 
of months to repay (between 240 and 360)) and based on the user input the 
application will calculate the monthly home loan repayment (if the monthly
repayment is more than third of the user’s monthly gross income the application will 
alert user that approval of home loan is unlikely) and will calculate the monthly 
available money. The application also asks user whether they want to buy a vehicle or not, 
based on the user response the application will ask user to input the values for buying the vehicle 
and according to the values enter the application will calculate the monthly cost for buying a vehicle and will also 
alter user if the expenses exceed 75% of the user income. 
--------------------------------------------------------------------------------------------------------------------
**************************************************************************************************************************************************************
Features
--------------------------------------------------------------------------------
   --User input with exception handling
   --Makes use of good comments to follow and guide through the program
   --Makes use of graphical interface 
   --Provides calculations of approval of loans by using compound interest formula
--------------------------------------------------------------------------------
**************************************************************************************************************************************************************
Installations instructions and Instructions on How to use the application
--------------------------------------------------------------------------------------------------------------------
   --Unzip the folder  
   --Place it in repos folder
   --If you do not have the visual studio you won't be able to place the folder in the repos,
     so to download the visual studio heres the link: https://visualstudio.microsoft.com/downloads/,
     I would recommed you to doenload the community version.
   --Once the folder is placed in the repos open the folder ishpreetKaur_POEPart1
   --Then open the folder POEPart1Version2 -> bin -> debug -> select POEPart1Version2 application
   --The application gets start to do the Budgeting calculations
   --Once the application start running it will ask user to input the gross income, 
     monthly tax deducted and monthly expenditures (groceries, water and light, travel 
     cost (including petrol), cell phone and telephone, other expenditures), once the user 
     enter all these values it will display the gross income(after tax deduction) and the expenses values
     and will also display the amount of total expenses.
   --The application then asks user to make a choice between renting accommodation or buying a property,
     If you did not input 1 or 2 the application will ask you again to make a choice, 
     so make sure that you input either 1 or 2.
   --If a user input “1” (renting accommodation) the application will ask user to 
     enter their monthly rent amount and then the application calculate and display the 
     available monthly money.
   --If a user input “2” (Buy a property) the application will ask user to input the values for 
     a home loan (Purchase price of the property, Total deposit, Interest 
     rate(percentage), number of months to repay (between 240 and 360)).
     If a user did not input the number of months to repay between 240 and 360 the 
     application will again ask user to input the number of months to repay 
   --After inputting the home loan values the app will display all the home loan values. 
     The application will calculate and display monthly home loan repayment and
     also display if the approval of home loan is likely or unlikely and available monthly 
     money after all the specified deductions have been made.
   --The application will ask whether the user want to buy the vehicle or not
   --If they do want to buy the vehicle then the application will ask user to input the values for the vehicle
   --Then the application will display the values in formatted way and display the monthly cost for buying a vehicle
   --The application then also display whether the expenses exceed 75% of the user income or not
   --Application also display the expenses in descensing order 
   --Finally the application display the available balance after the deductions
   --The application ask user whether the users want to resume the app or not
------------------------------------------------------------------------------------------------------------------------
**************************************************************************************************************************************************************
FAQs
--------------------------------------------------------------------------------
  --Q1: What happens if we input the wrong input for the numerical values?
        If you input the string values in the numerical inputs the application will 
        throw a message saying Please enter a valid numerical value and then it will
        ask you again to input correct values

  --Q2: Does it save the data somewhere?
        No, it does not save the data. But it does save the data in the memory only when the app is runing.

  --Q3: Does the Alter only show after we make choice for buying a vehicle?
        No, Even though if you do not want to buy a vehicle it will Alter you whether your expenses 
        and loan repayments exceed 75% of your gross monthly income.

  --Q4: What happens if i accidently press the enter key?
        If you press the enter key accidently the program will still run but i will only takes the values 
        that you have entered and other values it will take as null.
**************************************************************************************************************************************************************
Developer contact info 
--------------------------------------------------------------------------------
   --Name: Ishpreet Kaur
   --Student number: ST10084227
   --Email ID: ST10084227@vcconnect.edu.za
   --Cell number: +27791936637
--------------------------------------------------------------------------------
***************************************************************************************************************************************************************
Git Hub Link
--------------------------------------------------------------------------------
https://github.com/IshpreetKaur3535/PROG2A_POEPart1_ST10084227
--------------------------------------------------------------------------------
***************************************************************************************************************************************************************
Code Attribution
----------------------------------------------------------------------------------------------------------------------------------------------------
   -- GeeksforGeeks.(2021).Program for EMI Calculator. Available at: https://www.geeksforgeeks.org/program-emi-calculator/. [Accessed 10 May 2022]
   -- Maze,C. (2022). Catch Multiple Exceptions in C#. Available at: https://rb.gy/dmfehv
   -- TutorialsTeacher. (2022). C# - List<T>. Available at: https://www.tutorialsteacher.com/csharp/csharp-list.
-----------------------------------------------------------------------------------------------------------------------------------------------------


