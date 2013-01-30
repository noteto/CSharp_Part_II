using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1.//Write a program that reads a year from the console and checks whether it is a leap. Use DateTime.

class IsYearLeap
{
    static void Main()
    {
        Console.Write("Enter a year for check if it's leap: ");
        ushort year = ushort.Parse(Console.ReadLine());

        while (year < 0)
        {
            Console.Write("Enter valid year: ");
            year = ushort.Parse(Console.ReadLine());
        }

        if (DateTime.IsLeapYear(year))
        {
            Console.WriteLine("Year {0} is leap", year);
        }
        else
        {
            Console.WriteLine("Year {0} is NOT leap", year);
        }
    }
}
