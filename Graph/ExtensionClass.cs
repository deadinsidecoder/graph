using System;
using System.Collections.Generic;

namespace Graph
{
    public static class ExtensionClass
    {
        public static void DisplayArray(this int[,] array)
        {
            Console.WriteLine();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.Write($" |  {i + 1}  | ");
            }
            Console.WriteLine();
            
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.Write(i + 1);
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($" |  {array[i, j]}  | ");
                }
                Console.WriteLine();
            }
        }

        public static void DisplayList<T>(this List<T> list)
        {
            Console.WriteLine();

            foreach (var item in list)
            {
                Console.WriteLine(item.ToString());
            }
            
            Console.WriteLine();
        }
        
    }
}