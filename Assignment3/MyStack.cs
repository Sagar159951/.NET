using System;
using System.Collections;
using System.Collections.Generic;
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
            Console.WriteLine(_stackSize);
            if(stack.Count == _stackSize)
            {
                Console.WriteLine("Stack is full");
                return;
            }
            stack.Add(this._top);
        }
        public void Pop()
        {
            if (stack.Count == 0)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            stack.RemoveAt(stack.Count - 1);
        }

        public void DisplayStack()
        {
            foreach(int i in stack)
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
        }
    }
}