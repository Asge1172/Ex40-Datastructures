using System;

namespace Datastructures
{
    public class MyStack<T>
    {
        private StackItem top = null;
        private StackItem bottom = null;

        private class StackItem
        {
            public T Item { get; }

            public StackItem Previous { get; set; }

            public StackItem(T o)
            {
                Item = o;
                Previous = null;
            }
        }

        public int StackCount { get; set; }

        public MyStack() {
        }

        public void Push(T item)
        {
            StackItem nextStackItem = new StackItem(item);
            if (StackCount == 0)
            {
                bottom = nextStackItem;
            }
            if (StackCount > 0)
            {
                StackItem lastStackItem = top;
                nextStackItem.Previous = top;
            }
            top = nextStackItem;
            StackCount++;
        }

        public T Pop()
        {
            StackItem thisTop = top;
            top = top.Previous;
            StackCount--;
            return thisTop.Item;
        }

        public T Peek()
        {
            return top.Item;
        }

        public int Count()
        {
            return StackCount;
        }
    }
}
