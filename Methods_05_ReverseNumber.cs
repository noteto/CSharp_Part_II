using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a method that reverses the digits of given decimal number. Example: 256 -> 652.

namespace task16_methods06
{
    class ReverseIntegerNumber
    {
        static int ReverseNumber(int number)
        {
            string num = number.ToString();
            string reverse = new string(num.ToCharArray().Reverse().ToArray());
            int revNumber = Convert.ToInt32(reverse);
            return (revNumber);
        }

        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int newNumber = ReverseNumber(number);
            
            Console.WriteLine(newNumber);
        }
    }
}
