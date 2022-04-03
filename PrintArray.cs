using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class PrintArray
    {
        public static void PrintAnArray(int[] arr)
        {
            Console.WriteLine("Integer array elements");
            foreach (int element in arr)
            {
                Console.WriteLine(element);
            }
        }
        public static void PrintAnArray(double[] arr)
        {
            Console.WriteLine("\nDouble array elements");
            foreach (double element in arr)
            {
                Console.WriteLine(element);
            }
        }
        public static void PrintAnArray(char[] arr)
        {
            Console.WriteLine("\nCharacter array elements");
            foreach (char element in arr)
            {
                Console.WriteLine(element);
            }
        }
    }
}
