using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//6. You are given a sequence of positive integer values written into a string, separated by spaces. Write a function that reads these values from given string and calculates their sum. Example:
//string = "43 68 9 23 318" -> result = 461


class SumStringElements
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        char[] chars = new char[] { ' ', ',', '-', '/' };
        string[] inputSplitted = input.Split(chars, StringSplitOptions.RemoveEmptyEntries);
        
        int sum = 0;
        for (int i = 0; i < inputSplitted.Length; i++)
        {
            if (i == inputSplitted.Length - 1)
            {
                Console.Write("{0}", inputSplitted[i]);
            }
            else
            {
                Console.Write("{0} + ", inputSplitted[i]);
            }
            sum = sum + int.Parse(inputSplitted[i]);
        }
        Console.Write(" = {0}\n", sum);
    }
}
