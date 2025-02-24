using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = 10;
            int[] mas = new int[size];
            Foreach(mas);
            Console.ReadKey();  
        }
        static void Foreach(int[] mas)
        {
            For(mas);
            foreach (int element in mas)
            {
                Console.WriteLine(element);
            }
        }
        static void For(int[] mas)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = i;
            }
        }
    }
}
