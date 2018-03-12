using System;

namespace Datastructures
{
    public class MyQueue<T>
    {
        private QueueItem head = null;
        private QueueItem tail = null;
        public T Head
        { get
        {
                T result = default(T);
                if (QueueCount > 0)
                {
                    result = head.Item;
                }
                return result;
        }
        }

        public T Tail
        { get
            {
                T result = default(T);
                if (QueueCount > 0)
                {
                    result = tail.Item;
                }
                return result;
            }
        }

        public int QueueCount { get; set; }


        public MyQueue()
        {

        }

        public void Enqueue(T item)
        {
            QueueItem nextQueueItem = new QueueItem(item);
            if (QueueCount == 0)
            {
                head = nextQueueItem;
            }
            if (QueueCount > 0)
            {
                QueueItem lastQueueItem = tail;
                lastQueueItem.Next = tail;               
            }
            tail = nextQueueItem;
            QueueCount++;
        }

        public T Dequeue()
        {
            QueueItem first = head;
            QueueItem nextFirst = first.Next;
            head = first.Next;
            QueueCount--;
            return first.Item;
        }

        public int Count()
        {
            return QueueCount;
        }

        public Boolean IsEmpty()
        {
            return true;
        }

        private class QueueItem
        {
            public T Item { get; }

            public QueueItem Next { get; set; }

            public QueueItem(T o)
            {
                Item = o;
                Next = null;
            }
        }
    }
}
