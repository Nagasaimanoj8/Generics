using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass
{
     class GenericClass<T>
    {
        public T[] arr;
        public GenericClass(T[] arr)
        {
            this.arr = arr; 
        }
        public  void PrintAnArray()
        {
            Console.WriteLine("\n Array elements");
            foreach (var element in arr)
            {
                Console.WriteLine(element);
            }
        }


    }
}
