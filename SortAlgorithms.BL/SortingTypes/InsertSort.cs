using System;
using System.Collections.Generic;

namespace SortAlgorithms.BL
{
    /// <summary>
    /// Сортировка вставками.
    /// </summary>
    /// <typeparam name="T">Обобщение.</typeparam>
    public class InsertSort<T> : AlgorithmsBase<T> where T : IComparable
    {
        /// <summary>
        /// Конструктор с добавлением элементов.
        /// </summary>
        /// <param name="items">Элементы.</param>
        public InsertSort(IEnumerable<T> items) : base(items) { }

        /// <summary>
        /// Пустой конструктор.
        /// </summary>
        public InsertSort() { }

        /// <summary>
        /// Метод реализации сортировки вставками.
        /// </summary>
        protected override void MakeSort()
        {
            for(int i = 1; i< Items.Count; i++)
            {
                var temp = Items[i];
                var j = i;
                while(j > 0 && temp.CompareTo(Items[j - 1]) == -1)
                {
                    Items[j] = Items[j - 1];
                    j--;
                    SwapCount++;
                    ComparisonCount++;
                }
                Items[j] = temp;
            }
        }
    }
}
