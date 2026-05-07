using System.Text;
using static System.Console;

class Program
{
    public static void Main()
    {
        WriteLine("Hello World!");
        string str = "I love Elephant";
        var result = ReverseString(str);
        WriteLine(result);
       
        result = ReverseString("Alfred Obialo");
        WriteLine(result);
        
        result = ReverseString("James Okoye");
        WriteLine(result);
        
        result = ReverseString("This is a very long text, hope you enjoy it?");
        WriteLine(result);
        return;
        char[] separator = { ',' };
        string name = "Alfred,        Chioma,     Blessing    , Okeke    ,     Chibuzor     ";
        
        var splittedNames = name.Split(separator, StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < splittedNames.Length; i++)
        {
            splittedNames[i] = splittedNames[i].Trim();
        }
        Array.Sort(splittedNames,StringComparer.InvariantCultureIgnoreCase);
        var sortedNames = string.Join(", ", splittedNames);
        WriteLine($"Sorted names: {sortedNames}\nUnsorted Names : {name}");
        

        int[] studentAges;
        studentAges = new int[5];
        
        bool[] customerAgreementToTerms = new bool[5];
        int ageMultiples = 5 , arrIndex = 0 , startingNumber = 15;
        foreach (var age in studentAges )
        {
            if(arrIndex == 0)
            {
                studentAges[0] = startingNumber;
            }
            else
            {
                studentAges[arrIndex] = studentAges[arrIndex - 1] + ageMultiples;
            }
            WriteLine("Student Age: " + studentAges[arrIndex]);
            arrIndex++;
            
        }

        string[,] students = new string[3, 4];

        students[0, 0] = "Reg No";
        students[0, 1] = "First Name";
        students[0, 2] = "Last Name";
        students[0, 3] = "Age";
        
        var lwBound = students.GetLowerBound(0);
        var upBound = students.GetUpperBound(0);
        WriteLine($"Upper Bound: {upBound}, Lower Bound: {lwBound}");
        
        // Jagged Array
        int[][] jagged = new int[4][]; 
        jagged[0] = new int[2];
        jagged[1] = new int[3];
        jagged[2] = new int[5];
        jagged[3] = new int[1];
        
        jagged[0] = new int[2];
        return;
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
        sum = AddNumbers(10,20,30,29,30,40,58,90,100);
        Console.WriteLine($"SUm is now : {sum}");
        
        
        
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
