using System;
using System.Collections.Generic;

namespace SortAlgorithms.BL
{
    /// <summary>
    /// Сортировка выбором.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class SelectionSort<T> : AlgorithmsBase<T> where T : IComparable
    {
        /// <summary>
        /// Конструктор с добавлением элементов.
        /// </summary>
        /// <param name="items">Элементы.</param>
        public SelectionSort(IEnumerable<T> items) : base(items) { }

        /// <summary>
        /// Пустой конструктор.
        /// </summary>
        public SelectionSort() { }

        /// <summary>
        /// Метод реализации сортировки выбором.
        /// </summary>
        protected override void MakeSort()
        {
            var minIndex = 0;

            for (int i = 0; i < Items.Count - 1; i++)
            {
                minIndex = i;

                for (int j = i + 1; j < Items.Count; j++)
                {
                    if (Items[j].CompareTo(Items[minIndex]) == -1)
                    {
                        minIndex = j;
                    }
                }

                if (i != minIndex)
                {
                    Swap(i, minIndex);
                }
            }
        }
    }
}
