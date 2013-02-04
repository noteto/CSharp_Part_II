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

//VARIANT 2 - for negative numbers

//class ReverseDigits
//{
//    static void Main()
//    {
//        ReverseDecimal(decimal.Parse(Console.ReadLine()));
//    }
//    static void ReverseDecimal(decimal number)
//    {
//        string numberString = number.ToString(); //convert the input in string
//        char[] numberChar = numberString.ToCharArray(); // then convert the string to array of chars
//        char[] reversedNumberChar = new char[numberChar.Length];
//        for (int i = 0; i < numberChar.Length; i++) // reverse the array of chars
//        {
//            reversedNumberChar[numberChar.Length - i - 1] = numberChar[i];
//        }
//        for (int i = 0; i < reversedNumberChar.Length; i++) // print the final array of chars. 45 is the ascii code of "-"
//        {
//            if (reversedNumberChar[i] == 45)
//            {
//                break; //if decimal is < 0 print the reversed number without "-" behind it
//            }
//            Console.Write(reversedNumberChar[i]);
//        }
//        Console.WriteLine();
//    }
//}
