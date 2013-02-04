using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Retrun Last Digit of an integer as a word

namespace task13_methods03
{
    class ReturnLastDigit
    {
        static void ReturnDigit(int number)
        {
            int digit = number % 10;

            switch (digit)
            {
                case 9: Console.Write("nine"); break;
                case 8: Console.Write("eight"); break;
                case 7: Console.Write("seven"); break;
                case 6: Console.Write("six"); break;
                case 5: Console.Write("five"); break;
                case 4: Console.Write("four"); break;
                case 3: Console.Write("three"); break;
                case 2: Console.Write("two"); break;
                case 1: Console.Write("one"); break;
                case 0: Console.Write("zero"); break;
                default: Console.Write("Not a number!"); break;
            }
        }

        static void Main()
        {
            Console.Write("Enter an integer number: ");
            int number = int.Parse(Console.ReadLine());
            ReturnDigit(number);
            Console.WriteLine();
        }
    }
}
