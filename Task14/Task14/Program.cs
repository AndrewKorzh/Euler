using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task14
{
    internal class Program
    {
   
        static void Main(string[] args)
        {
            int max = 0;
            int n = 1000000;
           for (int i = 2; i < n; i++)
           {
                int cl = chain_len(i);
                if (cl > max ) max = cl;
           }
            Console.WriteLine($"Res: {max}");
        }
        static int chain_len(int n)
        {
            int count = 1;
            while (n > 1) {
                //Console.Write($"{n} -> " );
                count++;
                if (n % 2 == 0)
                {
                    n /= 2;
                }
                else n = n * 3 + 1;
              
            }
           // Console.WriteLine(n);

            return count;
        }
    }
}
