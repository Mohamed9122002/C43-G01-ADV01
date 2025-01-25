using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentSession01C_Advanced.Question01
{
    //Create a generic class named Range<T> where T represents the type of values.
    internal class Range<T> where T : struct, IComparable<T>
    {
        //Implement a constructor that takes the minimum and maximum values to define the range.

        private T max;
        private T min;

        public Range()
        {
            max = default(T);
            min = default(T);
        }
        //. Implement a method IsInRange(T value) that returns true if the given
        //    value is within the range, otherwise false. 
        public Range(T Max, T Min)
        {
            this.max = Max;
            this.min = Min;
        }

        public bool IsRange(T item)
        {
            return item.CompareTo(min) >= 0 && item.CompareTo(max) <= 0;
        }

        public T Length()
        {
            dynamic maxDynamic = max;
            dynamic minDynamic = min;
            return maxDynamic - minDynamic;
        }

    }
}
