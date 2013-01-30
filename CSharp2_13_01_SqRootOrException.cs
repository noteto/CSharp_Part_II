using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1.Write a program that reads an integer number and calculates and prints its square root. If the number is invalid or negative, print "Invalid number". 
//In all cases finally print "Good bye". Use try-catch-finally.

class SqrtOrExceptions
{
    static void Main()
    {
        string s = Console.ReadLine();

        try
        {
            Int32.Parse(s);
            int sqrt = Convert.ToInt32(s);
            if (sqrt <= 0)
            {
                throw new ArithmeticException();
            }
            Console.WriteLine("Squre root of {0}: +{1}; -{1}", s, Math.Sqrt(sqrt));
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid number! The number is not integer!");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Invalid number! The number is too big to fit in Int32!");
        }
        catch (System.ArgumentNullException)
        {
            Console.WriteLine("Invalid number! Nothing entered!");
        }
        catch (System.ArithmeticException)
        {
            Console.WriteLine("Invalid number! The number is negative or zero!");
        }
        finally
        {
            Console.WriteLine("Good bye!");
        }
    }
}
