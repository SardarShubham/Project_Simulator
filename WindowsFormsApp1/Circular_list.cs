using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    // class Circular list
    class Circular_list<T>
    {
        int n;
        int front_pointer, rear_pointer;
        T [] list;
        T [] copyList;
        int count;
        public Circular_list(int size)
        {
            n = size; // maximum size of circular array
            list = new T [size];    // array
            front_pointer = rear_pointer = -1;  // front and rear pointers
            copyList = new T [size];    // final string after traversal
            count = 0;
        }

        public int getCount()
        {
            return count;
        }
        // method to add new item into the cirular array
        public void add(T item)
        {
            // if the array is full
            if (front_pointer == (rear_pointer + 1) % n)
            {
                front_pointer = (front_pointer + 1) % n;
            }
            // incrementing rear pointer and adding item at that index
            rear_pointer = (rear_pointer + 1) % n;
            list[rear_pointer] = item;
            // setting proper index 
            if (front_pointer == -1) front_pointer = 0;
            if (count < n) count++;
        }

        // method to get concanated string after traversal
        public T[] CopyTo()
        {
            int i = 0;
            int temp = front_pointer;
            // if array is empty
            if (front_pointer == -1) return null;
            // concanating string starting from front to rear index in circular pattern
            while (true)
            {
                copyList[i] = list[temp];
                if (temp == rear_pointer) break;
                temp = (temp + 1) % n;
                i++;
            }
            // returning the string
            return copyList;
        }
    }

    
}
