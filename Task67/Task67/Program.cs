using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Task67
{
    
    internal class Program
    {
        static int Max_int(int a, int b) { 
            if (a > b)
                return a;
            return b; 
        }
        static void Main(string[] args)
        {
            var tr = File.ReadAllLines("triangle.txt");
            var just_tr= new List<List<int>>();
            var triangle_of_max = new List<List<int>>();
            for (int i = 0; i < tr.Length; i++)
            {
                var st = tr[i].Split(' ');
                just_tr.Add(new List<int>());
                foreach (string x in st)
                    just_tr[i].Add(int.Parse(x));

            }
            for (int i = 0; i < just_tr.Count; i++)
            {
                Console.WriteLine($"Layer {i + 1}:");
                for (int j = 0; j < just_tr[i].Count; j++)
                    Console.Write($"{just_tr[i][j]} ");
                Console.WriteLine();


            }
            //Realisation
            //Добавляем вершину
            triangle_of_max.Add(new List<int>());
            triangle_of_max[0].Add(just_tr[0][0]);
            for (int i = 1; i < just_tr.Count; i++)
            {
                //добавляем слой
                triangle_of_max.Add(new List<int>());
               // Console.WriteLine("test");
                //Первый эл-т слоя - это первый предыдущего и первый из тогоже слоя исходного
                triangle_of_max[i].Add(triangle_of_max[i-1][0] + just_tr[i][0]);
                for (int j = 1; j < just_tr[i].Count-1; j++)
                {
                    //Тут просто - выбираем наибольший из тех, из которых можем прийти
                    triangle_of_max[i].Add(just_tr[i][j] + Max_int(triangle_of_max[i - 1][j], triangle_of_max[i - 1][j - 1]));

                
                }
                //Последний эл-т слоя - это последний предыдущего и последний из тогоже слоя исходного
                triangle_of_max[i].Add(triangle_of_max[i - 1][triangle_of_max[i-1].Count-1] + just_tr[i][just_tr[i].Count - 1]);


            }
            Console.WriteLine("Наш тр-к:");
            for (int i = 0; i < triangle_of_max.Count; i++)
            {
                Console.WriteLine($"Layer {i+1}:");
                for (int j = 0; j < triangle_of_max[i].Count; j++)
                    Console.Write($"{triangle_of_max[i][j]} ");
                Console.WriteLine();


            }
            int res = int.MinValue;
            foreach (int i in triangle_of_max[triangle_of_max.Count - 1])
                if (i > res)
                    res = i;

            Console.WriteLine($"res: {res}");
        }
    }
}
