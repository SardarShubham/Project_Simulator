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
    class Circular_list
    {
        int size;
        int front_pointer, rear_pointer;
        string[] list;
        private string display_result;
        public Circular_list()
        {
            size = 3;   // maximum size of circular array
            list = new string[size];    // array
            front_pointer = rear_pointer = -1;  // front and rear pointers
            display_result = "";    // final string after traversal
        }

        // method to add new item into the cirular array
        public void add(string item)
        {
            // if the array is full
            if (front_pointer == (rear_pointer + 1) % size)
            {
                front_pointer = (front_pointer + 1) % size;
            }
            // incrementing rear pointer and adding item at that index
            rear_pointer = (rear_pointer + 1) % size;
            list[rear_pointer] = item;
            // setting proper index 
            if (front_pointer == -1) front_pointer = 0;
        }

        // method to get concanated string after traversal
        public string display()
        {
            display_result = "";
            int temp = front_pointer;
            // if array is empty
            if (front_pointer == -1) return null;
            // concanating string starting from front to rear index in circular pattern
            while (true)
            {
                display_result = display_result + list[temp] + "\r\n";
                if (temp == rear_pointer) break;
                temp = (temp + 1) % size;
            }
            // returning the string
            return display_result;
        }
    }

    
}
