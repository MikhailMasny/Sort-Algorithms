using System;
using System.Collections.Generic;

namespace SortAlgorithms.BL
{
    /// <summary>
    /// Быстрая сортировка.
    /// </summary>
    /// <typeparam name="T">Обобщение.</typeparam>
    public class QuickSort<T> : AlgorithmsBase<T> where T : IComparable
    {
        /// <summary>
        /// Конструктор с элементами.
        /// </summary>
        /// <param name="items">Элементы.</param>
        public QuickSort(IEnumerable<T> items) : base(items) { }

        /// <summary>
        /// Пустой конструктор.
        /// </summary>
        public QuickSort() { }

        /// <summary>
        /// Метод реализации быстрой сортировки.
        /// </summary>
        protected override void MakeSort()
        {
            Qsort(0, Items.Count - 1);
        }

        /// <summary>
        /// Реализация сортировки.
        /// </summary>
        /// <param name="left">Левая часть.</param>
        /// <param name="right">Правая часть.</param>
        private void Qsort(int left, int right)
        {
            if (left >= right)
            {
                return;
            }

            var pivot = Sorting(left, right);
            Qsort(left, pivot - 1);
            Qsort(pivot + 1, right);
        }

        /// <summary>
        /// Сортировка.
        /// </summary>
        /// <param name="left">Левая часть.</param>
        /// <param name="right">Правая часть.</param>
        /// <returns>Возвращает маркер.</returns>
        private int Sorting(int left, int right)
        {
            var pointer = left;

            for (int i = left; i <= right; i++)
            {
                if (Items[i].CompareTo(Items[right]) == -1)
                {
                    Swap(pointer, i);
                    pointer++;
                }
            }

            Swap(pointer, right);
            return pointer;
        }
    }
}
