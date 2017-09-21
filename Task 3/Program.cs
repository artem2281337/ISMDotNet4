using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, s = 0;
            Console.WriteLine("Stroki : ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Colonki : ");
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

            int sum = 0;
            int co = 0;
            int sl = 0;


            if (a == b)
            {
                for (int i = 0; i < a; i++)
                {
                    for (int j = 0; j < b; j++)
                    {
                        if ((j > i) && (m[i, j] >= 0))
                        {
                            sum += m[i, j];
                            co++;
                        }
                        if (j > i)
                        {
                            sl += m[i, j];
                        }

                    }

                }
                Console.WriteLine();
                Console.WriteLine("Количество + элементов рядом с диагональю:{0},Сумма = {1} ", co, sum);
                Console.WriteLine("summa elementov =  " + sl);
            }

            if (a != b)
            {
                Console.WriteLine("Wrong");
            }
            int a, b, s = 0;
            Console.WriteLine("Stroki : ");
            r = int.Parse(Console.ReadLine());
            Console.WriteLine("Kolonki : ");
            c = int.Parse(Console.ReadLine());
            int[,] m = new int[a, b];
            Random rnd = new Random();
            for (int i = 0; i < a; i++)
            {
                for (int k = 0; k < b; k++)
                {
                    m[i, j] = rnd.Next(0, 20);
                    Console.Write(m[i, j] + "  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            int sum = 0;
            int co = 0;
            int sl = 0;


            if (a == b)
            {
                for (int i = 0; i < a; i++)
                {
                    for (int j = 0; j < b; j++)
                    {
                        if ((j > i) && (m[i, j] >= 0))
                        {
                            sum += m[i, j];
                            co++;
                        }
                        if (j > i)
                        {
                            sl += m[i, j];
                        }

                    }

                }

                Console.WriteLine("Количество положительных элементов рядом с диагональю:{0}, sum = {1} ", co, sum);
                Console.WriteLine("Сумма всех элементов =  " + sl);
            }

            if (a != b)
            {
                Console.WriteLine("Matrix должна быть сведенной");
            }
        }
    }
}
