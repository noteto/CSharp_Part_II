using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//2. Write a program that generates and prints to the console 10 random values in the range [100, 200].

class RandomNumbers
{
    static void Main()
    {
        Random rand = new Random();
        
        for (int number = 1; number <= 10; number++)
        {
            int randomNumber = rand.Next(100,201);
            Console.Write("{0} ", randomNumber);
        }
    }
}
