using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentSession01C_Advanced.Question03
{
    internal class NewListEven<T>
    {
        public static T[]  ArraryListEven ( T [] array)
        {
            //T[] NewArray = new T[Aarry.Length / 2];

            int eventCount = 0;
            for (int i = 0; i < array.Length; i++)
            {
                //if (i % 2 == 0)  Why Error :Beacuse i is T type of Generics T -> Struct 
                // Struct Not Implemention == Operator
                // هل كده دا التفسير الصح ي بشمهندس
                if (Convert.ToInt32(array[i]) % 2 == 0)
                {
                    eventCount++;
                }
            }
            T[] NewArary = new T[eventCount];
            int index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (Convert.ToInt32(array[i]) % 2 == 0)
                {
                    NewArary[index] = array[i];
                    index++;
                }
            }
            return NewArary;


        }
    }
}
