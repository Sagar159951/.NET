using System;
using System.Collections;
using System.Collections.Generic;

namespace CreatingStackException
{
    public class StackException : Exception
    {
        public StackException():base(){}
        public StackException(string message):base(message){}
        public StackException(string message, Exception innerException):base(message, innerException){}

    }
}

namespace CreatingMyStack
{
    interface ICloneable
    {
        void Push();
        void Pop();
    }
    public class MyStack : ICloneable
    {
        private List<int> stack = new List<int>();
        private int _top;
        public int Top { get { return _top; } set { this._top = value; } }
        private int _stackSize;
        public int StackSize { get { return _stackSize; } set { this._stackSize = value; } }

        public void Push()
        {
            try
            {
                if (stack.Count == _stackSize)
                {
                    throw new CreatingStackException.StackException("Stack is full, cannot perform push.");
                }
                stack.Add(this._top);
            }catch (Exception e)
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
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }
        }

        public void DisplayStack()
        {
            foreach (int i in stack)
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
            MyStack stack = new MyStack();
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