using SortAlgorithms.BL.DataStructures;
using System;

namespace SortAlgorithms.BL
{
    /// <summary>
    /// Сортировка кучей.
    /// </summary>
    /// <typeparam name="T">Обобщение.</typeparam>
    public class HeapSort<T> : AlgorithmsBase<T> where T : IComparable
    {
        /// <summary>
        /// Метод реализации сортировки кучей.
        /// </summary>
        protected override void MakeSort()
        {
            var heap = new Heap<T>(Items);
            var sorted = heap.Order();
            Items = sorted;
        }
    }
}
