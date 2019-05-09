using System;
using System.Collections.Generic;

namespace SortAlgorithms.BL
{
    /// <summary>
    /// Сортировка Шелла.
    /// </summary>
    /// <typeparam name="T">Обобщение.</typeparam>
    public class ShellSort<T> : AlgorithmsBase<T> where T : IComparable
    {
        /// <summary>
        /// Конструктор с добавлением элементов.
        /// </summary>
        /// <param name="items">Элементы.</param>
        public ShellSort(IEnumerable<T> items) : base(items) { }

        /// <summary>
        /// Пустой конструктор.
        /// </summary>
        public ShellSort() { }

        /// <summary>
        /// Метод реализации сортировки Шелла.
        /// </summary>
        protected override void MakeSort()
        {
            var step = Items.Count / 2;

            while(step > 0)
            {
                for (int i = step; i < Items.Count; i++)
                {
                    int j = i;
                    while ((j >= step) && Items[j - step].CompareTo(Items[j]) == 1)
                    {
                        Swap(j - step, j);
                        j -= step;
                    }
                }

                step /= 2;
            }
        }
    }
}
