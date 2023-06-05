using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long sum_of = 0;
            long of_sums = 0;
            int n = 100;
            for (int i = 1; i<=n;i++)
            {
                sum_of += i*i;
                of_sums += i;

            }
            of_sums *= of_sums;
            Console.WriteLine($"Сумма квадратов:{sum_of} \nКвадрат суммы:{of_sums} \nRes:{of_sums - sum_of}");

        }
    }
}
