using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = 20;
            long[,] arr = new long[n + 1, n + 1]; 
            for (int i = 0; i < arr.GetLength(0); i++)
            { 
              arr[i, 0] = 1;
              arr[0, i] = 1;
            }
            for (int j = 1; j <= n; j++)
            { 
                for (int i = 1; i <= n; i++)
                    arr[i, j] = arr[i, j - 1] + arr[i-1, j];
           
            }
            
            for (int i = 0; i < n+1; i++)
            {
                for (int j = 0; j < n + 1; j++)
                    Console.Write($"{arr[i, j]} ");
                Console.WriteLine(  );

            }
            Console.WriteLine($"{arr[n,n]}");
        }
    }
}
