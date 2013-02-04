using System;
using System.Collections.Generic;

//Convert from any base to any base ([2..16])

class AnyBaseToBase
{
    static int ConvertToDecimal(string number, int baseFrom)
    {
        int decimalNum = 0;
        for (int i = 0; i < number.Length; i++)
        {
            if (number[i] > '9')
            {
                decimalNum += (number[i] - '7') * (int)Math.Pow(baseFrom, (number.Length - 1 - i));
            }
            else
            {
                decimalNum += (number[i] - '0') * (int)Math.Pow(baseFrom, (number.Length - 1 - i));
            }
        }
        return decimalNum;
    }

    static void ConvertFromDecimal(int number, int baseTo)
    {
        List<int> result = new List<int>();
        if (baseTo > 10)
        {
            while (number > 0)
            {
                result.Add(number % baseTo);
                number = number / baseTo;
            }
            result.Reverse();
            foreach (var item in result)
            {
                switch (item)
                {
                    case 10: Console.Write("A");
                        break;
                    case 11: Console.Write("B");
                        break;
                    case 12: Console.Write("C");
                        break;
                    case 13: Console.Write("D");
                        break;
                    case 14: Console.Write("E");
                        break;
                    case 15: Console.Write("F");
                        break;
                    default: Console.Write(item);
                        break;
                }
            }
            Console.WriteLine();
        }
        else
        {
            while (number > 0)
            {
                result.Add(number % baseTo);
                number = number / baseTo;
            }
            result.Reverse();
            foreach (var item in result)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
    }

    static void Main()
    {
        Console.Write("Please enter a number: ");
        string number = (Console.ReadLine()).ToUpper();
        Console.Write("Please enter the numeral system FROM: ");
        int s = int.Parse(Console.ReadLine());
        Console.Write("Please enter the numeral system TO: ");
        int d = int.Parse(Console.ReadLine());

        if (s < 2 || d < 2 || s > 16 || d > 16)
        {
            Console.WriteLine("The numeral systems must be in the range [2 .. 16]");
        }
        else
        {
            ConvertFromDecimal(ConvertToDecimal(number, s), d);
        }
    }
}
