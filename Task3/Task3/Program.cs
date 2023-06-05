using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static bool is_prime(long n) { 
            for (int i = 2; i < Math.Sqrt(n)+1; i++) {
                if (n % i == 0)
                    return false;
            }
            return true;
        
        }
        static void Main(string[] args)
        {
            long i = 600851475143;
            long d = 2;
            while (true)
            {
                if (d >= i)
                {
                    Console.WriteLine(d);
                    break;
                }
                if (is_prime(d) && i % d == 0)
                {
                    Console.WriteLine(d);
                    i /= d;
                }
                else d++;



            }
        }
    }
}
