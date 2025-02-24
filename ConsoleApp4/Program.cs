using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] mas = { 5, 12, 8, 20, 3, 15, 7 };
            int num = 5;
            Sravn(mas, num);
            Console.ReadLine();
        }
        static void Sravn(int[] mas, int num)
        {
            {
                for (int i = 0; i < mas.Length; i++)
                {
                    if (mas[i] > num)
                    {
                        Console.WriteLine($"mas{i} = {mas[i]} > {num}");
                    }
                }
            }
        }
    }
}
