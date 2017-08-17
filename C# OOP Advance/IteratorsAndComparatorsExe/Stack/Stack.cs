using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Stack
{
    public class Stack<T> : IEnumerable<T>
    {
        private const int Capasity = 10;
        public Stack()
        {
            this.List = new T[Capasity];
            this.Count = 0;
        }

        public T[] List { get; private set; }

        public int Count { get; private set; }

        public void Resize()
        {
            this.List = this.List.Concat(new T[Capasity]).ToArray();
        }

        public void Push(T element)
        {
            this.List[this.Count] = element;
            this.Count++;
            if (Count == this.List.Length - 1)
            {
                this.Resize();
            }
        }

        public void Pop()
        {
            if (this.Count == 0)
            {
                throw new ArgumentException("No elements");
            }
            this.Count--;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = this.Count -1 ; i >=0; i--)
            {
                yield return this.List[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}