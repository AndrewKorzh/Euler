using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task30
{
    internal class Program
    {
        static int sum_of_digit_pow_5(int x) { 
            int res = 0;

            while (x > 0)
            {
                res += (int)Math.Pow(x % 10, 5);
                x /= 10;
            }
            
            return res;
        
        }
        static void Main(string[] args)
        {
            int sum = 0;
            //Тому, что i меньше 100000 есть строгое математическое доказательство (ну, если я правильно всё сделал...)
            for (int i = 10; i < 100000; i++)
            {
                if (i == sum_of_digit_pow_5(i))
                {
                    Console.WriteLine(i);
                    sum += i;
                }
            }
            Console.WriteLine($"Res: {sum}");
        }
    }
}
