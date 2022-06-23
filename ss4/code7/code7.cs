using System;
class Months
{
    static void Main(string[] args)
    {
        string input;
        Console.WriteLine("Entor the month");
        input = Console.ReadLine().ToUpper();
        switch (input)
        {
            case "JANUARy":
            case "MARCH":
            case "MAY":
            case "JUlY":
            case "AUGST":
            case "OCTOBER":
            case "DECEMBER":
                Console.WriteLine("This month has 31 days");
                break;
            case "APRIL":
            case "JUNE":
            case "SETEMBER":
            case "NOVEMBER":
                Console.WriteLine("This month has 30days");
                break ;
            case "FEBRUARY":
                Console.WriteLine("This month has 28days in a non-leap year and 29 days in a leap year");
                break;
            default:
                Console.WriteLine("Incorrect choice");
                break;

        }
    }
}
