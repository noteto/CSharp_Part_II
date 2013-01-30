using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//4. Write methods that calculate the surface of a triangle by given: Side and an altitude to it; 
//Three sides; Two sides and an angle between them. Use System.Math.

class TriangleSurface
{
    static void SurfaceSlideAltitude()
    {
        Console.Write("Enter side A > 0: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter altitude H > 0: ");
        double h = double.Parse(Console.ReadLine());
        
        double surface = (a * h) / 2;
        Console.WriteLine("\nTriangle's surface is (a * h) / 2 = {0}", surface);
    }

    static void SurfaceThreeSides()
    {
        Console.Write("Enter side A > 0: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter side B > 0: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter side C > A+B: ");
        double c = double.Parse(Console.ReadLine());
        
        while (c <= (a + b))
        {
            Console.Write("Enter correct side C > A+B: ");
            c = double.Parse(Console.ReadLine());
        }

        double p = (a + b + c) / 2;
        double surface = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        Console.WriteLine("\nTriangle's surface is = {0}", surface);
    }

    static void SurfaceAngle()
    {
        Console.Write("Enter side A > 0: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter side B > 0: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter an angle:");
        double angle = double.Parse(Console.ReadLine());

        double surface = (a * b * Math.Sin(Math.PI * angle / 180)) / 2;
        Console.WriteLine("\nTriangle's surface is (a * b * sinx) / 2 = {0}", surface);
    }

    static void Main()
    {
        Console.WriteLine("Choose a method to calculate triangle's surface:");
        Console.WriteLine("1 - By side, and altitude to it\n2 - By 3 sides\n3 - By 2 sides and angle between them");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine("\nChoice 1:");SurfaceSlideAltitude();break;
            case 2:
                Console.WriteLine("\nChoice 2:");SurfaceThreeSides(); break;
            case 3:
                Console.WriteLine("\nChoice 3:");SurfaceAngle(); break;
            default:
                Console.WriteLine("\nIncorrect number for choice!"); break;
        }
    }
}
