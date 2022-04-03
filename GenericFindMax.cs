using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
     class GenericFindMax<T> where T: IComparable
    {
        public T first, second, third;
        public GenericFindMax(T first,T second,T third)
        {
            this.first = first;
            this.second = second;
            this.third = third;

        }
        public static T FindMax(T first, T second, T third)
        {
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
            {
                Console.WriteLine("first having max value" + first);
                return first;
            }
            else if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
            {
                Console.WriteLine("second having max value" + second);
                return second;
            }
            else if (third.CompareTo(second) > 0 && third.CompareTo(third) > 0)
            {
                Console.WriteLine("third having max value" + first);
                return third;
            }
            else
            {
                Console.WriteLine("May be 2 or 3 values are equal");
                return default;
            }
        }
        public void TestMaximumValue()
        {
            FindMax( first,  second,  third);
        }

    }
}
