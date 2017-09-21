using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISMDotNet4
{
    class Program
    {
        static void Main(string[] args)
        {
            int m, n, a, b;
            Console.WriteLine("n  = ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("m  = ");
            m = int.Parse(Console.ReadLine());
            
            Random rnd = new Random();


            
            Console.WriteLine("a  = ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("b  = ");
            b = int.Parse(Console.ReadLine());

            int[,] o = new int[n, m];
            int[,] p = new int[a, b];
            int[,] prod = new int[n, b];
            Console.WriteLine("M n: ");
            for (int z = 0; z < a; z++)
            {
                for (int k = 0; k < b; k++)
                {
                    o[z, k] = rnd.Next(1, 20);
                    Console.Write("[{0},{1}] = {2}", z, k, o[z, k]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("Mas m: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    p[i, j] = rnd.Next(1,20);
                    Console.Write("[{0},{1}] = {2}", i, j, p[i, j]);
                }
                Console.WriteLine();
            }
            
            Console.WriteLine();

            for (int row = 0; row < n; row++)
            {
                for(int col = 0;col < b;col++)
                {
                    for(int inner = 0;inner < m; inner++) {
                        
                        prod[row,col] += o[row, inner] * p[inner, col];
                    }
                    Console.Write(prod[row, col] + "  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
