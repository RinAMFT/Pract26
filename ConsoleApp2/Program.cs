using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] mas = new int[10];
            RandomValue(mas);
            Output(mas);
            Console.ReadKey();
        }

        static void RandomValue(int[] mas)
        {
            Random random = new Random();
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = random.Next(-10, 11);
            }
        }

        static void Output(int[] mas)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                Console.WriteLine($"mas[{i}] = {mas[i]}");
            }
        }
    }
}
