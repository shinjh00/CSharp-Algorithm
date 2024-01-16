using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class Queue<T>
    {
        private const int DefaultCapacity = 4;

        private T[] array;
        private int front;
        private int rear;

        public Queue()
        {
            array = new T[DefaultCapacity];
            front = 0;
            rear = 0;
        }

        public int Count
        {
            get
            {
                if (front <= rear)
                    return rear - front;
                else
                    return rear + (array.Length - front);
            }
        }

        public void Clear()
        {
            array = new T[DefaultCapacity];
            front = 0;
            rear = 0;
        }

        public void Enqueue(T item)
        {
            if (IsFull())
            {
                Grow();
            }

            array[rear] = item;
            MoveNext(ref rear);
        }

        public T Dequeue()
        {
            if (IsEmpty())
                throw new InvalidOperationException();

            T result = array[front];
            MoveNext(ref front);
            return result;
        }

        public T Peek()
        {
            if (IsEmpty())
                throw new InvalidOperationException();

            return array[front];
        }

        private void Grow()
        {
            int newCapacity = array.Length * 2;
            T[] newArray = new T[newCapacity];
            if (front < rear)
            {
                Array.Copy(array, front, newArray, 0, rear);
            }
            else
            {
                Array.Copy(array, front, newArray, 0, array.Length - front);
                Array.Copy(array, 0, newArray, array.Length - front, rear);
            }

            array = newArray;
            rear = Count;
            front = 0;
        }

        private bool IsFull()
        {
            if (front > rear)
            {
                return front == rear + 1;
            }
            else
            {
                return front == 0 && rear == array.Length - 1;
            }
        }

        private bool IsEmpty()
        {
            return front == rear;
        }

        private void MoveNext(ref int index)
        {
            index = (index + 1) % array.Length;
        }
    }
}