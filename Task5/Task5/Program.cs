using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = 20;

            long num = 1;
            List<int> list = new List<int>();
            for (int i = 2; i <= N; i++)
            {
                list.Add(i);
            }
            for (int i = 2;i < list.Count(); i++)
            {
                for (int j = 2; j < i; j++)
                {

                    if (list[i] % j == 0)
                        list[i] /= j;
                }
                Console.WriteLine(list[i]);
            }
            foreach (int i in list)
            {
               
                num *= i;
            }
            Console.WriteLine($"Res:{num}");
        }
    }
}
