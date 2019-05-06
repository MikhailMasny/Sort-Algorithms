using SortAlgorithms.BL.DataStructures;
using System;

namespace SortAlgorithms.BL
{
    public class HeapSort<T> : AlgorithmsBase<T> where T : IComparable
    {
        protected override void MakeSort()
        {
            var heap = new Heap<T>(Items);
            var sorted = heap.Order();
            Items = sorted;
        }
    }
}
