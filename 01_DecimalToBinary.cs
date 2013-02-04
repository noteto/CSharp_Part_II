using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Decimal To Binary

class DecToBin
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());   //9
        int number = n;
        int tempNumberAfterDivBy2;
        string binary = "";

        while (n >= 1)
        {
            tempNumberAfterDivBy2 = n /2 ;          //4                   //2                   //1                     //0
            binary = binary + (n % 2).ToString();   //n=9  binary = "1"  //n=4 binary = "10"    //n=2 binary = "100"   //n=1 binary = "1001"
            n = tempNumberAfterDivBy2;              //n=4                //2                    //n=1                  //n=0
        }

        char[] arr = binary.ToCharArray();          //variant1
        Array.Reverse(arr);
        string binaryReversed = new string(arr);

        string outputBinary = new string(binary.ToCharArray().Reverse().ToArray());  //variant 2

        Console.WriteLine("{0} in binary is {1}", number, binaryReversed);
        Console.WriteLine("{0}{10-base) = {1}(2-base)", number, outputBinary);
    }
}
