using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Astronomy
{
    public class QueueItem<T> 
    {
        public QueueItem(T value, QueueItem<T> next)
        {
            Value = value;
            Next = next;
        }
        public QueueItem<T> Next { get;  set; }
        public T Value { get; private set; }
    }
    public class Queue<T> : IEnumerable<T>
    {
        public Queue()
        {
            Count = 0;
            Head = null;
            Tail = null;
        }
        private QueueItem<T> Head { get;  set; }
        private QueueItem<T> Tail { get;  set; }
        public int Count { get; private set; }

        public void Enqueue(T value) 
        {
            Count++;
            if (Head == null)
            {
                Head = Tail = new QueueItem<T>(value, null);
                return;
            }
            var newItem = new QueueItem<T>(value, null);
            Tail.Next = newItem;
            Tail = newItem;
        }
        public T Dequeue() 
        {
            if (Head == null)
                throw new ArgumentException();
            var result = Head.Value;
            Head = Head.Next;
            return result;
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public IEnumerator<T> GetEnumerator()
        {
            var currentItem = this.Head;
            
            while(currentItem != null) 
            {
                yield return currentItem.Value;
                currentItem = currentItem.Next;
            }
        }

        
    }
}
