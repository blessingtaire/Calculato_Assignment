using System.Diagnostics;
using System.Text.RegularExpressions;
using static System.Console;

class Program
{
    public static void Main()
    {
        WriteLine("Hello World!");
        DisplayMyOpayBalance();
        SumNumbers();
        // PrintName method Usage
        PrintName("Adaeze Okeke");
        PrintName("Chioma Okafor");
        PrintName("Elephant");
        string myInstagramName = "alfredcsdinc_2021_funny_handle";
        PrintName(myInstagramName);
        Write("Please Enter Name here! : ");
        string dynamicNameToPrint  = ReadLine();
        WriteLine("==============================");
        PrintName(dynamicNameToPrint);
    }

    static void DisplayMyOpayBalance()
    {
        WriteLine("My Opay Balance is NGN 67,000");
    }
    
    static void SumNumbers()
    {
        var sum = 10 + 40; 
        WriteLine("Sum is : " + sum.ToString()); 
    }

    static void PrintName(string nameToPrint)
    {
        WriteLine(nameToPrint);
    }
}

