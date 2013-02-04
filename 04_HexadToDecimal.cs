using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Hexadecimal to Decimal

class HexToDec
{
    public static int ConvertToType(string myNumber, int type)
    {
        int size = myNumber.Length;
        int power = size - 1;
        int result = 0;
        int caseLetter = 0;
        for (int i = 0; i < size; i++)
        {
            switch (myNumber[i])
            {
                case 'A': caseLetter = 10; break;
                case 'B': caseLetter = 11; break;
                case 'C': caseLetter = 12; break;
                case 'D': caseLetter = 13; break;
                case 'E': caseLetter = 14; break;
                case 'F': caseLetter = 15; break;
                default: caseLetter = int.Parse(Convert.ToString(myNumber[i])); break;
            }
                result = result + caseLetter * (int)(Math.Pow(type, power));
                power--;
        }
            return result;
    }

    public static void Main()
    {
        Console.Write("Please Enter a Hexadecimal Number: ");
        string hex = Console.ReadLine();
        string myNumber = hex.ToUpper();
        Console.Write("({0}), base 16. Result In Decimal: ", hex);
        Console.WriteLine(ConvertToType(myNumber, 16));
    }
}
