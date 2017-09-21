using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, s = 0;
            Console.WriteLine("Stroki : ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Kolonki : ");
            b = int.Parse(Console.ReadLine());
            int[,] m = new int[a, b];
            Random rnd = new Random();
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    m[i, j] = rnd.Next(0, 20);
                    Console.Write(m[i, j] + "  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < a; i++)
            {
                for (int k = 0; k < b - 1; k++)
                {
                    s = s + m[i, k];
                    Console.WriteLine(m[i, k] + "  ");
                }
                Console.WriteLine();
                Console.WriteLine("  " + s);
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}
