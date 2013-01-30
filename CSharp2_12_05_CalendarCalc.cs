using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//5. Write a method that calculates the number of workdays between today and given date, passed as parameter. 
//Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.

class CalendarCalculate
{
    static void CalculateDays(DateTime today, DateTime finalDate, List<DateTime> holidays)
    {
        int numberOfDays = (finalDate - today).Days;
        int length = numberOfDays;
        DateTime tempDate = new DateTime();

        for (int i = 0; i <= length; i++)
        {
            tempDate = today.AddDays(i);

            if ((tempDate.DayOfWeek == DayOfWeek.Saturday) || (tempDate.DayOfWeek == DayOfWeek.Sunday))
            {
                numberOfDays--;
            }

            for (int days = 0; days < holidays.Count; days++)
            {
                int comparison = tempDate.CompareTo(holidays[days]); 
                if (comparison == 0)
                {
                    numberOfDays--;
                }
            }
        }

        Console.WriteLine("Today is: {0:D}", today);
        Console.WriteLine("Your Date is: {0:D}", finalDate);
        Console.WriteLine("Working days until {0:D} : {1}", finalDate, numberOfDays);
    }

    static void Main()
    {
        
        DateTime today = DateTime.Today;

        Console.Write("Enter the date you want to calculate as follows:\nYYYY-MM-DD: ");
        DateTime finalDate = DateTime.Parse(Console.ReadLine());

        var holidays = new List<DateTime>();
        holidays.Add(new DateTime(2013, 01, 01));
        holidays.Add(new DateTime(2013, 03, 03));
        holidays.Add(new DateTime(2013, 05, 06));
        holidays.Add(new DateTime(2013, 09, 06));
        holidays.Add(new DateTime(2013, 12, 24));
        holidays.Add(new DateTime(2013, 12, 25));
        
        CalculateDays(today, finalDate, holidays);
    }
}
