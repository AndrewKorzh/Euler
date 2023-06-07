using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> res = new List<int>();
            int[,] s = new int[100, 50];
            long sum = 0;
            var f = File.ReadAllLines("numbers.txt");
            for (int i = 0; i < f.Length; i++)
            {
                for (int j = 0; j < f[i].Length; j++)
                {
                    s[i,j] = int.Parse(f[i][j].ToString());
                
                }
            }


            for (int i = 0; i < s.GetLength(1); i++)
            {
                Console.Write($"{i} ");
                int r_sum = 0;
                for (int j = 0; j < s.GetLength(0); j++)
                {
                    
                    Console.Write(s[j, i]);
                    r_sum += s[j, i];

                }
                
                res.Insert(0, r_sum);
                r_sum = 0;
                Console.WriteLine();

            }
            List<int> final = new List<int>();
            Console.WriteLine();
            for (int i = 0; i < res.Count; i++)
            {
                Console.WriteLine($"{i}: {res[i]} ");
                final.Insert(0, (res[i] % 10));

            }

            for (int i = 0; i < final.Count; i++)
            {
                
                final.Add(res[i] % 10);
                Console.WriteLine($"{final[i]}");
            }

            //Потом подумаю  
            // Console.WriteLine($"Res: {sum}");
        }
    }
}
