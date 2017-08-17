using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class Sorter
    {
        public static CustomList<T> Sort<T>(CustomList<T> list)
            where T : IComparable<T>
        {
            var temp = list.List.OrderBy(x => x);
            return new CustomList<T>(temp);
        }
    }
}
