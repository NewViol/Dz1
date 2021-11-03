using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class Program
{
    static void Main(string[] args)
    {
        double b = 0, a = 0, c = 0, x;

        Console.Write("a:");
        double.TryParse(Console.ReadLine(), out a);
        Console.Write("b:");
        double.TryParse(Console.ReadLine(), out b);
        Console.Write("c:");
        double.TryParse(Console.ReadLine(), out c);


        if (c < 0 && b > 0) 
        {
            Console.WriteLine("{0}x^2 + {1}x {2} = 0", a, b, c);
        }
        else if (b < 0 && c > 0) 
        {
            Console.WriteLine("{0}x^2 {1}x + {2} = 0", a, b, c);
        }
        else if (b < 0 && c < 0)
        {
            Console.WriteLine("{0}x^2 {1}x {2} = 0", a, b, c);
        }
        else {
            Console.WriteLine("{0}x^2 + {1}x + {2} = 0", a, b, c);
        }

        double D = b * b - 4 * a * c;

        if (c < 0 && a > 0)
        {
            Console.WriteLine("D = {0}^2 - 4 * {1} * ({2}) = {3}", b, a, c, D);
        }
        else if (a < 0 && c > 0)
        {
            Console.WriteLine("D = {0}^2 - 4 * ({1}) * {2} = {3}", b, a, c, D);
        }
        else if (a < 0 && c < 0)
        {
            Console.WriteLine("D = {0}^2 - 4 * ({1}) * ({2}) = {3}", b, a, c, D);
        }
        else
        {
            Console.WriteLine("D = {0}^2 - 4 * {1} * {2} = {3}", b, a, c, D);
        }

        if (D < 0)
        {
            Console.WriteLine("No result");
        }
        else if (D == 0)
        {
            Console.WriteLine("One result");
            x = -1 * b / 2 * a;
            Console.WriteLine("x = {0}", x);
        }
        else
        {
            Console.WriteLine("Two results");
            x = (-1 * b - Math.Sqrt(D)) / 2 * a;
            Console.WriteLine("x1 = {0}", x);
            x = (-1 * b + Math.Sqrt(D)) / 2 * a;
            Console.WriteLine("x2 = {0}", x);
        }
    }

}
