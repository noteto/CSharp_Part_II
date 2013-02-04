using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a method that counts how many times given number appears in given array. Write a test program to check if the method is working correctly.

namespace task14_methods04
{
    class CountNumberInArrayCheck
    {
        static int CountNumberInArray(int numberCheck, int[] array, int arrLength)
        {
            int counter = 0;
            for (int i = 0; i < arrLength; i++)
            {
                if (array[i] == numberCheck)
                {
                    counter++;
                }
            }
            return counter;
        }

        static void Main()
        {
            Console.Write("Enter a number for check: ");
            int numberCheck = int.Parse(Console.ReadLine());
             Console.Write("Enter a number for array's length: ");
            int arrLength = int.Parse(Console.ReadLine());
            int[] array = new int[arrLength];
            for (int i = 0; i < arrLength; i++)
            {
                Console.Write("arr[{0}]= ", i);
                array[i] = int.Parse(Console.ReadLine());
            }
            CountNumberInArray(numberCheck, array, arrLength);
            Console.WriteLine("Number {0} is found {1} time(s).", numberCheck, CountNumberInArray(numberCheck, array, arrLength));
        }
    }
}
