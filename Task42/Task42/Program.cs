using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task42
{
    internal class Program
    {
        static bool is_triangle(double Tn) { 
            double d = 1 + 8 * Tn;
            if (d > 0)
            {
                double x = (-1 + Math.Sqrt(d)) / 2;
                if (Convert.ToInt32(x) == Convert.ToDouble(x))
                    return true;
                return false;
            }
            return false;
        }
        static int str_to_Letter_sum(string str) { 
            int sum = 0;
            string s = str.ToUpper();
            for (int i = 0; i < s.Length; i++)
            {
                sum += (int)s[i]-64;
            }
            return sum;
        }
        static bool word_is_triangle(string s) {
            return is_triangle(str_to_Letter_sum(s));
        }
        static void Main(string[] args)
        {
            int count = 0;
            string path = "words.txt";
            var words_str = File.ReadAllText(path);
            var words_lst = words_str.Split(',');
            foreach (var word in words_lst)
            {
                string w = word.Substring(1, word.Length - 2);
                if (word_is_triangle(w))
                {
                    Console.WriteLine(w);
                    count++;

                }
                   
            }
            Console.WriteLine($"Res: {count}");


        }
    }
}
