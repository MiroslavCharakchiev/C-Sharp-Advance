using System;
using System.Collections;
using System.Collections.Generic;

namespace ListyIterator
{
    public class ListyIterator<T> : IEnumerable<T>
    {
        private List<T> list;
        public ListyIterator(params T[] list)
        {
            this.list = new List<T>(list);
            this.Count = 0;
        }

        public int Count { get; private set; }


        public Boolean Move()
        {
            if (this.list.Count - 1 > Count)
            {
                Count++;
                return true;
            }
            return false;
        }

        public Boolean HasNext()
        {
            if (this.list.Count-1 > Count)
            {
                return true;
            }
            return false;
        }

        public void Print()
        {
            if (this.list.Count > Count)
            {
                Console.WriteLine(this.list[Count]);
            }
            else
            {
                Console.WriteLine("Invalid Operation!");
            }
        }


        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.list.Count; i++)
            {
                yield return this.list[i];
            }
        }
        
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}