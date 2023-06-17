using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int c = 1; c<1000; c++)
            {
                for (int a = 1; a < 1000-c; a++)
                {
                    int b = 1000 - a - c;

                    if (b * b + a * a == c * c)
                    {
                        Console.WriteLine($"a = {a}, b = {b}, c = {c}");
                        Console.WriteLine($"a*b*c = {a*b*c}");
                        return;
                    }
                }


            }
        }
    }
}
