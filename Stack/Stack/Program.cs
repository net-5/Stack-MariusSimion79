using System;
using System.Collections.Generic;
using System.Linq;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            // Reach the last element of the stack without destroying the stack


            Stack<int> myStack = new Stack<int>();
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);
            myStack.Push(5);
            Console.WriteLine("Initially, the stack is: ");
            foreach (var elem in myStack)
            {
                Console.WriteLine(elem);
            }

            var last = myStack.Last();
            Console.WriteLine();
            Console.WriteLine($"The last element of the stack is: {last}");
            Console.WriteLine();
            Console.WriteLine("After viewing the last element, the stack remain: ");
            foreach (var elem in myStack)
            {
                Console.WriteLine(elem);
            }
        }
    }
}
