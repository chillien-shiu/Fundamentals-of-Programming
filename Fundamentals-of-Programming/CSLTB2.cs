using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("1.  Add / Sum Two Numbers");
            Console.WriteLine("2.  Swap Values of Two Variables");
            Console.WriteLine("3.  Multiply two Floating Point Numbers");
            Console.WriteLine("4.  Convert Feet to Meters");
            Console.WriteLine("5.  Convert Celsius to Fahrenheit & Vice Versa");
            Console.WriteLine("6.  Find the Size of Data Types");
            Console.WriteLine("7.  Print ASCII Value of a Character");
            Console.WriteLine("8.  Calculate Area of Circle");
            Console.WriteLine("9.  Calculate Area of Square");
            Console.WriteLine("10. Convert Days to Years, Weeks, and Days");
            Console.WriteLine("0.  Exit");
            Console.WriteLine("==================================================");
            Console.Write("Choose an exercise (0-10): ");

            string choice = Console.ReadLine();
            Console.Clear();

            switch (choice)
            {
                case "1": Ex1_SumTwoNumbers(); break;
                case "2": Ex2_SwapTwoVariables(); break;
                case "3": Ex3_MultiplyFloatingNumbers(); break;
                case "4": Ex4_ConvertFeetToMeter(); break;
                case "5": Ex5_ConvertTemperature(); break;
                case "6": Ex6_SizeOfDataTypes(); break;
                case "7": Ex7_PrintASCIIValue(); break;
                case "8": Ex8_AreaOfCircle(); break;
                case "9": Ex9_AreaOfSquare(); break;
                case "10": Ex10_ConvertDays(); break;
                case "0":
                    Console.WriteLine("Exiting program. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice! Please select 0 to 10.");
                    break;
            }

            Console.WriteLine("\nPress any key to return to the menu...");
            Console.ReadKey();
        }
    }

    // 1. Add / Sum Two Numbers
    static void Ex1_SumTwoNumbers()
    {
        Console.WriteLine("--- 1. SUM TWO NUMBERS ---");
        Console.Write("Enter first number: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter second number: ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Sum: {a + b}");
    }

    // 2. Swap Values of Two Variables
    static void Ex2_SwapTwoVariables()
    {
        Console.WriteLine("--- 2. SWAP TWO VARIABLES ---");
        Console.Write("Enter first value (a): ");
        string a = Console.ReadLine();
        Console.Write("Enter second value (b): ");
        string b = Console.ReadLine();

        string temp = a;
        a = b;
        b = temp;

        Console.WriteLine($"After swapping: a = {a}, b = {b}");
    }

    // 3. Multiply two Floating Point Numbers
    static void Ex3_MultiplyFloatingNumbers()
    {
        Console.WriteLine("--- 3. MULTIPLY TWO FLOATING POINT NUMBERS ---");
        Console.Write("Enter first float number: ");
        float a = float.Parse(Console.ReadLine());
        Console.Write("Enter second float number: ");
        float b = float.Parse(Console.ReadLine());
        Console.WriteLine($"Result: {a * b}");
    }

    // 4. Convert Feet to Meter
    static void Ex4_ConvertFeetToMeter()
    {
        Console.WriteLine("--- 4. CONVERT FEET TO METERS ---");
        Console.Write("Enter length in feet: ");
        double feet = Convert.ToDouble(Console.ReadLine());
        double meters = feet * 0.3048;
        Console.WriteLine($"{feet} feet = {meters} meters");
    }

    // 5. Convert Celsius to Fahrenheit and Vice Versa
    static void Ex5_ConvertTemperature()
    {
        Console.WriteLine("--- 5. TEMPERATURE CONVERSION ---");
        Console.WriteLine("1. Celsius to Fahrenheit");
        Console.WriteLine("2. Fahrenheit to Celsius");
        Console.Write("Choose option (1-2): ");
        string opt = Console.ReadLine();

        if (opt == "1")
        {
            Console.Write("Enter Celsius: ");
            double c = Convert.ToDouble(Console.ReadLine());
            double f = (c * 9 / 5) + 32;
            Console.WriteLine($"{c}°C = {f}°F");
        }
        else if (opt == "2")
        {
            Console.Write("Enter Fahrenheit: ");
            double f = Convert.ToDouble(Console.ReadLine());
            double c = (f - 32) * 5 / 9;
            Console.WriteLine($"{f}°F = {c}°C");
        }
        else
        {
            Console.WriteLine("Invalid option!");
        }
    }

    // 6. Find the Size of Data Types
    static void Ex6_SizeOfDataTypes()
    {
        Console.WriteLine("--- 6. SIZE OF DATA TYPES ---");
        Console.WriteLine($"Size of char   : {sizeof(char)} byte(s)");
        Console.WriteLine($"Size of int    : {sizeof(int)} byte(s)");
        Console.WriteLine($"Size of float  : {sizeof(float)} byte(s)");
        Console.WriteLine($"Size of double : {sizeof(double)} byte(s)");
        Console.WriteLine($"Size of bool   : {sizeof(bool)} byte(s)");
        Console.WriteLine($"Size of long   : {sizeof(long)} byte(s)");
    }

    // 7. Print ASCII Value
    static void Ex7_PrintASCIIValue()
    {
        Console.WriteLine("--- 7. PRINT ASCII VALUE ---");
        Console.Write("Enter a character: ");
        char ch = Console.ReadKey().KeyChar;
        Console.WriteLine($"\nASCII value of '{ch}' is: {(int)ch}");
    }

    // 8. Calculate Area of Circle
    static void Ex8_AreaOfCircle()
    {
        Console.WriteLine("--- 8. CALCULATE AREA OF CIRCLE ---");
        Console.Write("Enter radius: ");
        double radius = Convert.ToDouble(Console.ReadLine());
        double area = Math.PI * radius * radius;
        Console.WriteLine($"Area of Circle: {area:F2}");
    }

    // 9. Calculate Area of Square
    static void Ex9_AreaOfSquare()
    {
        Console.WriteLine("--- 9. CALCULATE AREA OF SQUARE ---");
        Console.Write("Enter side length: ");
        double side = Convert.ToDouble(Console.ReadLine());
        double area = side * side;
        Console.WriteLine($"Area of Square: {area}");
    }

    // 10. Convert Days to Years, Weeks, and Days
    static void Ex10_ConvertDays()
    {
        Console.WriteLine("--- 10. CONVERT DAYS TO YEARS, WEEKS, DAYS ---");
        Console.Write("Enter total days: ");
        int totalDays = Convert.ToInt32(Console.ReadLine());

        int years = totalDays / 365;
        int weeks = (totalDays % 365) / 7;
        int days = (totalDays % 365) % 7;

        Console.WriteLine($"{totalDays} days = {years} year(s), {weeks} week(s), and {days} day(s)");
    }
}
