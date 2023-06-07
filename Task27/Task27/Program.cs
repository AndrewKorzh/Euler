using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task27
{
    internal class Program
    {
        static bool is_prime(int n) {
            if (n < 0)
                n = -n;

            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                    return false;

            }
            return true;
        }
        static void Main(string[] args)
        {
            
            int ko_a = 1000;
            int ko_b = 1000;
            int max_n = 0;
            int max_a = 0; int max_b = 0;
            for (int a = -ko_a + 1; a < ko_a; a++) { 
                for (int b = -ko_b; b <= ko_b; b++)
                {
                   // Console.WriteLine($"\na: {a}  b :{b}\n");
                    int n = 0;
                    while (true) {
                        if (is_prime(n * n + a * n + b))
                        {
                          //  Console.WriteLine($"{n}: {n * n + a * n + b}");
                            
                            if (n > max_n)
                            {
                                max_n = n;
                                max_a = a;
                                max_b = b;

                            }
                        }
                        else
                            break;
                        n++;
                    }
             

                }
            }
            Console.WriteLine($"max_a: {max_a}, max_b: {max_b}, max_n: {max_n}");
            Console.WriteLine($"res: {max_a*max_b}");
        }
    }
}
