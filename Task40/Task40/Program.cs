using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task40
{
    internal class Program
    {
        //Знаю, решение конченное, и я знаю как сделать лучьше(без создания этого огроменного массива), но не хочу
        static void Main(string[] args)
        {
           
            int n = 6;
            var sb = new StringBuilder();
            int i = 0;

            while (sb.Length < (int)Math.Pow(10, n)) {
                i++;
                sb.Append(i);
            }
          // Console.WriteLine(sb.ToString());
            int prod = 1;
            //Console.WriteLine(Math.Pow(10, 0));
            for (int j = 0; j <= n; j++)
            {
                //Console.WriteLine(sb[(int)Math.Pow(10, j) - 1]);
                prod *= int.Parse(sb[(int)Math.Pow(10, j)-1].ToString());

            }
            //Console.WriteLine();
            Console.WriteLine(prod);
        }
    }
}
