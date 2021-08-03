using System;
using System.Collections.Generic;
using System.Linq;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            List<string> list = new List<string>();
            for (int i = 0; i < count; i++)
            {
                list.Add(Console.ReadLine());
            }
            int[] indexes = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Swap(list, indexes[0], indexes[1]);
        }
        
        public static void Swap<T>(List<T> list, int index1, int index2)
        {
            T temp = list[index1];
            list[index1] = list[index2];
            list[index2] = temp;
            Console.WriteLine(String.Join("\n", list));
        }

    }
}
