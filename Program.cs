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
        PrintNameAndAge("Chioma Okafor", 23);
        PrintName("Elephant");
        string myInstagramName = "alfredcsdinc_2021_funny_handle";
        PrintName(myInstagramName);
        Write("Please Enter Name here! : ");
        string dynamicNameToPrint = ReadLine();
        WriteLine("==============================");
        PrintName(dynamicNameToPrint);
        Write("Enter Value 1:");
        var v1 = double.Parse(ReadLine());
        Write("Enter Value 2: ");
        var v2 = double.Parse(ReadLine());
        var sum = AddNumbers(v1, v2);
        WriteLine($"Sum of {v1:N0} and {v2:N0} is {sum:N}");
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

    static void PrintNameAndAge(string nameToPrint,int age)
    {
        WriteLine($"Name: {nameToPrint}, Age: {age}");
    }

    static double AddNumbers(double num1, double num2)
    {
        return num1 + num2;
    }
    static double SubstractNumbers(double num1, double num2)
    {
        return num1 - num2;
    }
}
