using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Hexadecimal To Binary

class HexToBin
{
    static void Main()
    {
        string hexInput = Console.ReadLine();
        string hex = hexInput.ToUpper();
        string result = AddBinDigits(hex);
        Console.WriteLine(result);
    }
    static string AddBinDigits(string hex)
    {
        string res = string.Empty;
        for (int i = 0; i < hex.Length; i++)
        {
            switch (hex.Substring(i, 1))
            {
                case "0": res += "0000 "; break;
                case "1": res += "0001 "; break;
                case "2": res += "0010 "; break;
                case "3": res += "0011 "; break;
                case "4": res += "0100 "; break;
                case "5": res += "0101 "; break;
                case "6": res += "0110 "; break;
                case "7": res += "0111 "; break;
                case "8": res += "1000 "; break;
                case "9": res += "1001 "; break;
                case "A": res += "1010 "; break;
                case "B": res += "1011 "; break;
                case "C": res += "1100 "; break;
                case "D": res += "1101 "; break;
                case "E": res += "1110 "; break;
                case "F": res += "1111 "; break;
                default: res += ""; break;
            }
        }
        return res;
    }
}
