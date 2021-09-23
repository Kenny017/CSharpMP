using System;
using System.Collections.Generic;

namespace ExerciseStack
{
    class Program
    {
        static void main(string[] args)
        {
            NewStack stack = new NewStack();
            string nullString = null;

            //   stack.Push(nullString); Simulating Invalid Operation Exception.
            //  stack.Pop(); Simulating Underflow Exception when Pop operation is used on a empty Stack.

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
        }
    }

    class NewStack
    {
        private readonly LinkedList<object> stack = new LinkedList<object>();

        public void Push(object objectToBeInserted)
        {
            if (objectToBeInserted != null)
                stack.AddFirst(objectToBeInserted);
            else
                throw new InvalidOperationException("Error. Cannot add null.");
        }
        
        public object Pop()
        {
            object toBeReturned;
            if (stack.Count == 0)
            {
                throw new InvalidOperationException("Error. Stack is Empty.");
            } else
            {
                 toBeReturned = stack.First.Value;
                 stack.RemoveFirst();
                 return toBeReturned;
            }

        }
        public void Clear() => stack.Clear();

    }
}
