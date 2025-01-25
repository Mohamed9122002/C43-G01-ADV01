using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentSession01C_Advanced.Question02
{
    internal class ArrayListReverser<T>
    {
        public static void ReverseArrayList( T [] arrayList)
        {
            int left = 0;
            int right = arrayList.Length - 1;
            while (left < right)
            {
                T temp = arrayList[left];
                arrayList[left] = arrayList[right];
                arrayList[right] = temp;
                left++;
                right--;
            }

        }
    }
}
