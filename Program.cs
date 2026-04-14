 using System;

 class program
 {
  static void Main(string[] args)
  {
   enterOption:
   Console.WriteLine("========CALCULATOR========");
   Console.WriteLine("SELECT AN OPTION");
   Console.WriteLine("1: ADDITION");
   Console.WriteLine("2: SUBTRACTION");
   Console.WriteLine("3: MULTIPLICATION");
   Console.WriteLine("4: DIVISION");
   string add = "ADDITION";
   string sub = "SUBTRACTION";
   string mul = "MULTIPLICATION";
   string div = "DIVISION";
   double num = double.Parse(Console.ReadLine());
   if (num != 1 && num != 2 && num != 3 && num != 4)
   {
    Console.Clear();
     goto enterOption;
   }
   Console.Clear();
   
   Console.WriteLine("========CALCULATOR========");
   repeatOp:
   if (num == 1)
   {
    Console.WriteLine("Enter a number for " + add);
   }
   else if (num == 2)
   {
    Console.WriteLine("Enter a number for " + sub);
   }
   else if (num == 3)
   {
    Console.WriteLine("Enter a number for " + mul);
   }
   else if (num == 4)
   {
    Console.WriteLine("Enter a number for " + div);
   }

   else
   {
    Console.WriteLine("What Operation do you want to perform");
   }

   double num1 = double.Parse(Console.ReadLine());
   Console.WriteLine("Enter a Second Number");
   double num2 = double.Parse(Console.ReadLine());

   Console.Clear();
   Console.WriteLine("========CALCULATOR========");
   
   if (num == 1)
   
   {
    Console.WriteLine($" {num1} + {num2} = {num1 + num2}");
   }
   else if (num == 2)
   {
    Console.WriteLine($" {num1} - {num2} = {num1 - num2}");
   }
   else if (num == 3)
   {
    Console.WriteLine($" {num1} * {num2} = {num1 * num2}");
   }
   else if (num == 4)
   {
    Console.WriteLine($" {num1} / {num2} = {num1 / num2}");
   }
   else
   {
    Console.WriteLine("You have entered a wrong number");
   }
   
   
   Console. WriteLine("Would you like to perform thesame operation?");
    
    Console. WriteLine("Press 1 to perform the same operation");
    Console. WriteLine("Press 0 to go to the Main Menu");
    double nxtOp = double.Parse(Console.ReadLine());
    Console.Clear();
    if (nxtOp == 1)
    {
     goto repeatOp;
    }
    else if (nxtOp == 0)
    {
     goto enterOption;
    }
    else
    {
     Console.WriteLine("Enter an option");
     goto enterOption;
    }
   
  }

  }

  
 
 
