using System;
using System.Collections;
using System.Collections.Generic;

namespace CreatingStackException
{
    public class StackException : Exception
    {
        public StackException() : base() { }
        public StackException(string message) : base(message) { }
        public StackException(string message, Exception innerException) : base(message, innerException) { }

    }
}

namespace CreatingMyStack
{
    interface ICloneable
    {
        void Push();
        void Pop();
    }
    public class MyStack<T> : ICloneable
    {
        private List<T> stack = new List<T>();
        private T _top;
        public T Top { get { return _top; } set { this._top = value; } }
        private T _stackSize;
        public T StackSize { get { return _stackSize; } set { this._stackSize = value; } }

        public void Push()
        {
            try
            {
                if (stack.Count.Equals(_stackSize))
                {
                    throw new CreatingStackException.StackException("Stack is full, cannot perform push.");
                }
                stack.Add(this._top);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }
        }
        public void Pop()
        {
            try
            {
                if (stack.Count == 0)
                {
                    throw new CreatingStackException.StackException("Stack is empty, cannot perform pop.");
                }
                stack.RemoveAt(stack.Count - 1);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }
        }

        public void DisplayStack()
        {
            foreach (T i in stack)
            {
                Console.WriteLine("Displaying Stack");
                Console.WriteLine(i);
            }
        }
    }
    public class Program
    {
        public static void Main()
        {
            MyStack<object> stack = new MyStack<object>();
            stack.StackSize = 3;
            stack.Top = 10;
            stack.Push();
            stack.Top = 20;
            stack.Push();
            stack.DisplayStack();
            stack.Pop();
            stack.DisplayStack();
            stack.Pop();
            stack.Pop();
        }
    }
}