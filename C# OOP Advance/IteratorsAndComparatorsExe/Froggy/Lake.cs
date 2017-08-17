using System.Collections;
using System.Collections.Generic;

namespace Froggy 
{
    public class Lake : IEnumerable<int>
    {
        private List<int> stones;

        public Lake(params int[] stones)
        {
            this.stones = new List<int>(stones);
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < this.stones.Count; i += 2)
            {
                yield return this.stones[i];
            }
            var index = this.stones.Count - 1 ;
            if (index % 2 == 0)
            {
                index--;

            }
            for (int i = index; i > 0; i -= 2)
            {
                yield return this.stones[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}