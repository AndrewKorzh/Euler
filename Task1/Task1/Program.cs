using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        //Вообще можно решить как сумму арифметической прогрессии
        //333*(3+999)/2+199*(5+995)/2
        static void Main(string[] args)
        {
            int s = 0;
            for (int i = 0; i <1000; i+=5) {
                s += i; 
            }
            for (int i = 0;i <1000; i+=3) {
                s += i;
            }
            Console.WriteLine(s);
        }
    }
}
