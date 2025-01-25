using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentSession01C_Advanced.Question04
{
    internal class FixedSizeList<T>
    {
        #region implement a custom list called FixedSizeList<T> with a predetermined capacity. This list should not allow more elements than its capacity and should provide clear messages if one tries to exceed it or access invalid indices.
        
        private T[] _items;
        private int  _count;
        public int Capacity { get; }
        public int Count { set
            {
                _count = value;
            }
        }
        #region Implement a constructor that takes the fixed capacity of the list as a parameter
        public FixedSizeList(int capacity)
        {
            if (Capacity < 0)
            {
                Console.WriteLine("Capacity must be greater than or equal to zero");
            }

            _items = new T[capacity];
            Capacity = capacity;
            _count = 0;
        } 
        #endregion
        #region Implement an Add method that adds an element to the list, but throws an exception if the list is already full.
        //Implement an Add method that adds an element to the list, but
        //throws an exception if the list is already full.
        public void Add(T item)
        {
            if (_count >= Capacity)
            {
                Console.WriteLine("The list is full");
            }
            _items[_count] = item;
            _count++;
            Console.WriteLine($"Item '{item}' added to the list.");
        } 
        #endregion
        #region Implement a Get method that retrieves an element at a specific index in the list but throws an exception for invalid indices.
        public T GetIndex(int index)
        {

            if (index <= 0 && index >= _count)
            {
                Console.WriteLine("Index is out of");
            }
            return _items[index];
        }

        #endregion
        #endregion
    }
}
