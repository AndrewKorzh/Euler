using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task46
{
    internal class Program
    {
        //У меня считалось минуту примерно
        static bool is_composite(int n) { 
            for (int i = 2; i <= Math.Sqrt(n)+1; i++) {
                if (n % i == 0)
                    return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            for (int i = 3; i < 10000; i+=2) {
                if (is_composite(i))
                {
                    bool flag = false;
                    
                    for (int h = 1; h <= i; h++)
                    {
                        for (int p = 1; p < i; p++)
                            if (p + 2 * h * h == i && !is_composite(p)) { 
                                flag = true;
                                Console.WriteLine($"{i} = {p} + 2*{h}^2");
                            }



                    }
                    Console.WriteLine(  );

                    if (!flag) { Console.WriteLine($"А вот и эта срань - {i}");
                        break;
                    }
                }
            }
        }
    }
}
