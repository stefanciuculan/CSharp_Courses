using System;
using System.Collections.Generic;

namespace Stack
{
    public class Stack
    {
        public List<object> _myStack = new List<object>();

        public List<object> MyStack
        {
            get { return _myStack; }
            set { _myStack = value; }
        }

        public void Push(object obj)
        {
            if (obj != null)
                MyStack.Insert(0, obj);
            else
                throw new InvalidOperationException("A null object cannot be pushed into " +
                    "the stack.");
        }

        public object Pop()
        {
            if (MyStack[0] != null)
            {
                var removedElement = MyStack[0];
                MyStack.Remove(MyStack[0]);
                return removedElement;
            }
            else
                throw new InvalidOperationException("The stack is empty! You cannot " +
                    "remove objects from an empty stack.");
        }

        public void Clear()
        {
            MyStack.Clear();
            Console.WriteLine("The stack has been cleared.");
        }
    }
}
