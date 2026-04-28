using System.Diagnostics;
using System.Text.RegularExpressions;
using static System.Console;

class Program
{
    public static void Main()
    {
        // 1. The Null-Coalescing Operator (??) && The Null-Conditional Operator (?.) 
        string customerAccountNumberFromDatabase = null;
        string myNull = customerAccountNumberFromDatabase ?? "0000000000";
        if (myNull == null ) 
        {
            WriteLine("MyNull Variable is Null");
            myNull = myNull?.Trim();
        } 
        WriteLine($"MyNull Variable is {myNull}");
        return;
        BinaryToBaseTenConversion("1010"); 
        BinaryToBaseTenConversion("0000111100011"); 
        BinaryToBaseTenConversion("10S10");
        BinaryToBaseTenConversion("01010");

        #region Code Block hidden

        WriteLine("BINARY CALCULATOR");

        var base10Num = 10;
        int num = base10Num;
        int base2 = 2;
        string result = "";
        /*binaryLoop:
        var rem = base10Num % base2;
        result = rem.ToString() + result;
        base10Num = (base10Num - (base10Num % base2)) /base2;
        if (base10Num > 0)
        {
            goto binaryLoop;
        }
        */
        /*
         *  CONVERT NUMBER IN Binary to BASE 10
         *  
         */
        
        
        
        
// Do..Loop
        /*do
        {
            var rem = base10Num % base2;
            result = rem.ToString() + result;
            base10Num = (base10Num - (base10Num % base2)) / base2;
        } while (base10Num > 0);*/
        int sum1To10 = 1 + 2 + 3 + 4 + 5 + 6 + 7 + 8 + 9 + 10;
        WriteLine(sum1To10);
        byte i = 1;
        string emoji = """
                        \__(0-0)__/ 
                       """;
        string odd = "", even = "";
        for (i = 1; i <= 10; i++)
        {
            if (i % 2 == 0)
            {
                even+=($"{i},");
            }

            if (i % 2 > 0)
            {
                odd+=($"{i},");
            }
        }
        even = even.TrimEnd(',');
        odd = odd.TrimEnd(',');
        WriteLine($"Even Numbers from 1 to 10 are : {even}");
        WriteLine($"Odd Numbers from 1 to 10 are : {odd}");
        WriteLine();

        int x = 1;
        int sum = 0;
        int endNumber = 100;
        for (x = 1; x <= endNumber; x++)
        {
            sum += x;
            
        }
        for (double y = 0.01; y <= 1.0; y += 0.5)
        {
            WriteLine($"Y is {y}");
        }
        WriteLine($"Sum from 1 to {endNumber:N0} is {sum:N0}");

        /*for (;;)
        {
            Thread.Sleep(60);
            Clear();
            if (i == 1)
            {
                Write("/ Processing...");
                i++;
            }
            else if (i == 2)
            {
                Write("| Processing...");
                i++;
            }

            else if (i == 3)
            {
                Write("\\ Processing...");
                i = 1;
            }

        }*/


        while (base10Num > 0)
        {
            var rem = base10Num % base2;
            result = rem.ToString() + result;
            base10Num = (base10Num - (base10Num % base2)) / base2;
        }

        WriteLine($"Converting {num} in base 10 to binary is : {result}");
        ReadLine();

        #endregion 
        
    }

    static void BinaryToBaseTenConversion(string binaryNumber)
    {
        if (string.IsNullOrEmpty(binaryNumber))
        {
            WriteLine("Please enter a valid Binary Number to continue");
            return;
        }
        
        binaryNumber = binaryNumber.Trim();
        // Ensure the number entered is valid binary : 0 and 1
        // And must start with a 1
        if (binaryNumber[0] != '1')
        {
            
            int index1 = binaryNumber.IndexOf("1");
            if (index1 > -1)
            {
                binaryNumber = binaryNumber.Substring(index1);
            }
            
            WriteLine($"Extracted Binary Number is : {binaryNumber}");
            
        }
        foreach (char c in binaryNumber)
        {
            if (c != '0' && c != '1')
            {
                WriteLine("Invalid Binary Number\n");
                return;
            }
        }
        
        // Logic
        var lenStr  = binaryNumber.Length; // 9
        long sum = 0;// "111100011"
        for (int i = 0; i < lenStr; i++)
        {
            sum += int.Parse(binaryNumber[i].ToString()) * (long)Math.Pow(2, lenStr - (i+1));
        }
        
        WriteLine($"{binaryNumber} in binary  to decimal is => {sum}");
        
    }

    #region Previous Main Entry with Typewriter animation

    static void Main_old(string[] args)
    {
        int counter = 0;
        bool forward = true;
        Write("Enter your name: ");
        string x = Console.ReadLine();
        Clear();
        checkCondition:
        if (forward)
        {
            // Alfred => 
            runForward:
            Console.Write(x[counter++]);
            Thread.Sleep(70);
            if (counter < x.Length)
            {
                goto runForward;
            }
            else
            {
                forward = false;
                Thread.Sleep(3000);
                goto checkCondition;
            }
        }
        else
        {
            runBackward:
            Clear();
            string str = x.Substring(0, --counter);
            Console.Write(str);
            Thread.Sleep(30);
            if (counter > 0)
            {
                goto runBackward;
            }
            else
            {
                forward = true;
                Thread.Sleep(2000);
                goto checkCondition;
            }
        }


        ReadLine();

        //
        enterOption:
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("========CALCULATOR========");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("SELECT AN OPTION");
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("1: ADDITION");
        Console.WriteLine("2: SUBTRACTION");
        Console.WriteLine("3: MULTIPLICATION");
        Console.WriteLine("4: DIVISION");
        Console.ResetColor();
        string add = "ADDITION";
        string sub = "SUBTRACTION";
        string mul = "MULTIPLICATION";
        string div = "DIVISION";
        Console.ForegroundColor = ConsoleColor.Cyan;
        string opt = Console.ReadLine() ?? "";
        Console.ResetColor();
        if (opt != "1" && opt != "2" && opt != "3" && opt != "4")
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("You entered an Invalid Menu Option, Please try again!");
            Console.ResetColor();
            goto enterOption;
        }

        Console.Clear();

        Console.WriteLine("========CALCULATOR========");
        repeatOp:
        if (opt == "1")
        {
            Console.WriteLine("Enter a number for " + add);
        }
        else if (opt == "2")
        {
            Console.WriteLine("Enter a number for " + sub);
        }
        else if (opt == "3")
        {
            Console.WriteLine("Enter a number for " + mul);
        }
        else if (opt == "4")
        {
            Console.WriteLine("Enter a number for " + div);
        }


        double num1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter a Second Number");
        double num2 = double.Parse(Console.ReadLine());

        Console.Clear();
        Console.WriteLine("========CALCULATOR========");

        if (opt == "1")

        {
            Console.WriteLine($" {num1} + {num2} = {(num1 + num2):N0}");
        }
        else if (opt == "2")
        {
            Console.WriteLine($" {num1} - {num2} = {(num1 - num2):N0}");
        }
        else if (opt == "3")
        {
            Console.WriteLine($" {num1} * {num2} = {(num1 * num2):N0}");
        }
        else if (opt == "4")
        {
            Console.WriteLine($" {num1} / {num2} = {(num1 / num2):N0}");
        }


        Console.WriteLine("Would you like to perform thesame operation?");

        Console.WriteLine("Press 1 to perform the same operation : ");
        Console.WriteLine("Press 0 to go to the Calculator Main Menu : ");
        Console.WriteLine("Press any key Exit the program : ");
        string nxtOp = Console.ReadLine() ?? "";
        Console.Clear();
        if (nxtOp == "1")
        {
            goto repeatOp;
        }
        else if (nxtOp == "0")
        {
            goto enterOption;
        }
        else
        {
            Console.WriteLine("Exiting Program!!!");
        }
    }

    #endregion
}
