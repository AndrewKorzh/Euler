using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task100
{
    internal class Program
    {
        static double f(long n) {
            //ЕЕЕЕ математика - ну там равенство с двумя переменными (кол-во синих и всего) - тут - из всего -> в сколько синих
            return (1 + Math.Sqrt(1 + 2 * n * n - 2*n))/2;
        }
        static void Main(string[] args)
        {
            long n = 1000000000000;
           while (true)
            {
                n++;
                if (Convert.ToInt32(f(n)) == Convert.ToDouble(f(n)))
                {
                    Console.WriteLine("Вот оно:");
                    Console.WriteLine($"Всего: {n} -> синих: {f(n)}");
                    break;
                }
                   // Console.WriteLine($"{n} -> {f(n)}");
            }

        }
    }
}
