using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CustomList
{
    public class CustomList<T> : ICustomList<T>
        where T : IComparable<T>
    {
        private readonly List<T> list;

        public CustomList() : this(Enumerable.Empty<T>())
        {
        }

        public CustomList(IEnumerable<T> collection)
        {
            this.list = new List<T>(collection);
        }

        public List<T> List
        {
            get { return this.list; }
           
        }

        public void Add(T element)
        {
            this.List.Add(element);
        }

        public T Remove(int index)
        {
            T element = this.List[index];
            this.List.RemoveAt(index);
            return element;
        }

        public bool Contains(T element)
        {
            if (List.Contains(element))
            {
                return true;
            }
            return false;
        }

        public void Swap(int index1, int index2)
        {
            var temp = List[index1];
            List[index1] = List[index2];
            List[index2] = temp;
        }

        public int CountGreaterThan(T element)
        {
            var count = 0;
            foreach (var item in List)
            {
                if (item.CompareTo(element) > 0)
                {
                    count++;
                }
            }
            return count;
        }

        public T Max()
        {
            T max = List.Max();
            return max;
        }

        public T Min()
        {
            T min = List.Min();
            return min;
        }

       

        public IEnumerator<T> GetEnumerator()
        {
            return List.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
