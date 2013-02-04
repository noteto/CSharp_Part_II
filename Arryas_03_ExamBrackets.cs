using System;
using System.Numerics;

//Brackets

namespace Problem_5_Brackets
{
    class Brackets
    {
        static void Main()
        {
            string input = Console.ReadLine();
            int lengthInput = input.Length;

            BigInteger[,] sequence = new BigInteger[lengthInput + 1, lengthInput + 2];
            sequence[0, 0] = 1;

            for (int i = 1; i <= lengthInput; i++)
            {
                if (input[i - 1] == '(')
                {
                    sequence[i, 0] = 0;
                }
                else
                {
                    sequence[i, 0] = sequence[i - 1, 1];
                }

                for (int j = 1; j <= lengthInput; j++)
                {
                    if (input[i - 1] == '(')
                    {
                        sequence[i, j] = sequence[i - 1, j - 1];
                    }
                    else if (input[i - 1] == ')')
                    {
                        sequence[i, j] = sequence[i - 1, j + 1];
                    }
                    else
                    {
                        sequence[i, j] = sequence[i - 1, j - 1] + sequence[i - 1, j + 1];
                    }
                }
            }
            Console.WriteLine(sequence[lengthInput, 0]);
        }
    }
}
