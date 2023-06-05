using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long sum = 0;
            int f1 = 0;
            int f2 = 1;
            while (true) {
                int b = f1 + f2;
                f1 = f2;
                f2 = b;
                if (f2 > 4000000)
                    break;
                if (f2 % 2 == 0)
                    sum += f2;
               

            }
            Console.WriteLine(sum);
        }
    }
}
