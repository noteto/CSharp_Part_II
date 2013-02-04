using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a method that reverses the digits of given decimal number. Example: 256 -> 652. 25,6 -. 6,52

namespace task16_methods06
{
    class ReverseIntNumber
    {
        static int ReverseNumber(int number)
        {
            string num = number.ToString();
            string reverse = new string(num.ToCharArray().Reverse().ToArray());
            int revNumber = Convert.ToInt32(reverse);
            return (revNumber);
        }

        static string ReverseNumberDecimal(decimal numberD)
        {
            string numD = numberD.ToString();
            string reverseD = new string(numD.ToCharArray().Reverse().ToArray());
            return (reverseD);
        }

        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int newNumber = ReverseNumber(number);
            Console.WriteLine(newNumber);

            decimal numberD = decimal.Parse(Console.ReadLine());
            Console.WriteLine(ReverseNumberDecimal(numberD));
        }
    }
}
