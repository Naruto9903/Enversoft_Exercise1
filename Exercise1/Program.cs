using System;
using System.Linq;

namespace Exercise1
{
    class Program
    {
        public static void Main(string[] args)
        {
            
            int[] list1 = new int[] { 1, 2, 3, 4, 5 };
            int[] list2 = new int[] { 3, 4, 5, 6, 7 };

            Console.WriteLine("Part a: Matching Values:");
            for (int x = 0; x < list1.Length; x++)
            {
                for (int y = 0; y < list2.Length; y++)
                {
                    int a = list1[x];
                    int b = list2[y];
                    if (a == b)
                    {
                        Console.WriteLine(list1[x]);
                    }
                }
            }
            Console.WriteLine("\nPart b: Only Values in List 1:");
            int[] list1Only = list1.Except(list2).ToArray();
            for(int z = 0; z < list1Only.Length; z++)
            {
                Console.WriteLine(list1Only[z]);
            }
            
            Console.WriteLine("\nPart c: Only Values in List 2:");
            int[] list2Only = list2.Except(list1).ToArray();
            for (int z = 0; z < list2Only.Length; z++)
            {
                Console.WriteLine(list2Only[z]);
            }
            Console.WriteLine("\nPress <ENTER> to continue");
            Console.ReadLine();
        }
    }
}