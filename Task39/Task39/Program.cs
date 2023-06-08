using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task39
{
    internal class Program
    {
        static int triangle_func(int p) {
            int count = 0;
            for (int a = 1; a < p / 2; a++)
            {
                for (int b = 1; b < p / 2; b++)
                {
                    int c = p - a - b;
                    if (a * a + b * b == c * c && a + b + c == p) {
                      // Console.WriteLine($"<{a};{b};{c}>");
                        count++;
                    }
                       
                }
            }
            return count/2;


        }
        static void Main(string[] args)
        {
            int max = 0;
            int p_gives_max = 0;
            for (int i = 1; i <= 1000; i++) {
            
                if (triangle_func(i) > max)
                { 
                    max = triangle_func(i);
                    p_gives_max = i;
                }
            }
            Console.WriteLine($"p = {p_gives_max} gives {max}");

        }
    }
}
