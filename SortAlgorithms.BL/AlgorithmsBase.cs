using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithms.BL
{
    public class AlgorithmsBase<T>
    {
        public List<T> Items { get; set; } = new List<T>();
        public void Swap(int positionA, int postitonB)
        {
            if(positionA < Items.Count && postitonB < Items.Count)
            {
                var temp = Items[positionA];
                Items[positionA] = Items[postitonB];
                Items[postitonB] = temp;
            }
        }
    }
}
