using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class GenericPrintArray
    {
        public static void PrintAnArray<T>(T[] arr)
        {
            
            Console.WriteLine("\nArray elements");
            foreach (T element in arr)
            {
                Console.WriteLine(element);
            }
        }


    }
}
