using static System.Console;
using System.Collections;
using NewProgram.killTheEnemyGame;
using NewProgram.StudentApp;

class Program
{
    public static void Main()
    {
        WriteLine("Testing Game!");
       PlayGame pg  =  new PlayGame();
       ReadLine();
    }

    static string ReverseString(string str)
    {
        string rstr = "";
        for (int i = 0; i < str.Length; i++)
        {
            rstr = str[i] + rstr;
        }

        return rstr;
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

    static void PrintNameAndAge(string nameToPrint, int age)
    {
        WriteLine($"Name: {nameToPrint}, Age: {age}");
    }

    static double AddNumbers(double num1, double num2)
    {
        return num1 + num2;
    }

    static double AddNumbers2(double num1, double num2)
    {
        return num1 + num2;
    }

    static double AddNumbers(params double[] nums)
    {
        return nums.Sum();
    }


    static double SubstractNumbers(double num1, double num2)
    {
        return num1 - num2;
    }
}
