using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class Program
    {
        static bool is_polindrom(int p) { 
            string s = p.ToString();
            for (int i = 0; i < s.Length/2; i++) {
                if (s[i] != s[s.Length - 1 - i])
                    return false;
            }
            return true;

        
        }
        static void Main(string[] args)
        {


            for (int i = 99; i >= 10; i--)
            {
                for (int j = 99; j >= 10; j--)
                {
                    int p = i * j;
                    if (is_polindrom(p))
                    {
                        Console.WriteLine(p);
                        Environment.Exit(0);
                    }

                }
            }
        }
    }
}
