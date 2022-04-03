using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class FindMaxUsingSort<T>
    {
        public int[] arr = new int[5];
        public T[] value;
        public FindMaxUsingSort(T[] value)
        {
            this.value = value;
        }
        public T[]SortMethod(T[] value)
        {
            Array.Sort(value);
            return value;
        }
        public T FindMax()
        {
            T[] res=SortMethod(value);
           return res[value.Length - 1];
        }
        public void PrintResult()
        {
            T res=FindMax();
            Console.WriteLine("Max value:"+res);
        }
    }
}
