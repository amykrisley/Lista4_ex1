using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista4_ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int[] y;
            int[] x;
            int m = 0;
            y = new int[10];
            x = new int[10];
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;

            for (int i = 0; i < 10; i++)
            {
                int tempN = i + 1;
                Console.Write("Digite o " + tempN.ToString() + " Valor:\n");
                y[i] = int.Parse(Console.ReadLine());

            }

            for (int b = 0; b < 10; b++)
            {
                m += y[b];
            }
            m = m / 10;

            for (int c = 0; c < 10; c++)
            {
                if (m > y[c])
                {
                    x[c] = 1;
                }
            }
            for (int d = 0; d < 10; d++)
            {
                a += x[d];
            }
            a = m;
            Console.WriteLine("A quantidade dos números menor que a média é \n" + a.ToString());
        }
    }
}
