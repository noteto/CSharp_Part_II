using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//3. Write a program that prints to the console which day of the week is today. Use System.DateTime.

class DayOfWeek
{
    static void Main()
    {
        DateTime today = DateTime.Now;
        Console.WriteLine("Today: {0}", today);
        
        object day = today.DayOfWeek;
        string dayStr = day.ToString();
        string dayStrUpper = dayStr.ToUpper();
 
        //Console.WriteLine("Day of week: {0}", today.DayOfWeek);
        Console.WriteLine("Day of week: {0}", dayStrUpper);
    }
}
