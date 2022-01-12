using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _123123
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведи броят на числата: ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("min = {0}", array.Min());
            Console.WriteLine("max = {0}", array.Max());
            Console.WriteLine("avg = {0:F2}", array.Average());
        }
    }

}

