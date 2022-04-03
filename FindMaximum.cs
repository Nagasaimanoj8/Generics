using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class FindMaximum
    {

        public static int FindMax(int first, int second, int third)
        {
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
            {
                Console.WriteLine("first having max value"+first);
                return first;
            }
           else if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
            {
                Console.WriteLine("second having max value" + second);
                return second;
            }
            else if  (third.CompareTo(second) > 0 && third.CompareTo(third) > 0)
            {
                Console.WriteLine("third having max value" + first);
                return third;
            }
            else
            {
                Console.WriteLine("May be 2 or 3 values are equal");
                return 0;
            }
        }
        public static float FindMax(float first, float second, float third)
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
                return 0;
            }
        }

    }
}
