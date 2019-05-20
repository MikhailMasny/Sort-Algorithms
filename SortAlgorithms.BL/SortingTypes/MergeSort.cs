using System;
using System.Collections.Generic;
using System.Linq;

namespace SortAlgorithms.BL
{
    /// <summary>
    /// Сортировка слиянием.
    /// </summary>
    /// <typeparam name="T">Обобщение.</typeparam>
    public class MergeSort<T> : AlgorithmsBase<T> where T : IComparable
    {
        /// <summary>
        /// Конструктор с элементами.
        /// </summary>
        /// <param name="items">Элементы.</param>
        public MergeSort(IEnumerable<T> items) : base(items) { }

        /// <summary>
        /// Пустой конструктор.
        /// </summary>
        public MergeSort() { }

        /// <summary>
        /// Метод реализации сортировки слиянием.
        /// </summary>
        protected override void MakeSort()
        {
            Items = Sort(Items);
        }

        /// <summary>
        /// Сортировка.
        /// </summary>
        /// <param name="items">Элементы.</param>
        /// <returns>Сортированный список.</returns>
        private List<T> Sort(List<T> items)
        {
            if (items.Count == 1)
            {
                return items;
            }

            var mid = items.Count / 2;

            var left = items.Take(mid).ToList();
            var right = items.Skip(mid).ToList();

            return Merge(Sort(left), Sort(right));
        }

        /// <summary>
        /// Слияние.
        /// </summary>
        /// <param name="left">Левый список.</param>
        /// <param name="right">Правый список.</param>
        /// <returns>Список (результат).</returns>
        private List<T> Merge(List<T> left, List<T> right)
        {
            var length = left.Count + right.Count;
            var leftPointer = 0;
            var rightPinter = 0;

            var result = new List<T>();

            for (int i = 0; i < length; i++)
            {
                if (leftPointer < left.Count && rightPinter < right.Count)
                {
                    if (left[leftPointer].CompareTo(right[rightPinter]) == -1)
                    {
                        result.Add(left[leftPointer]);
                        leftPointer++;
                    }
                    else
                    {
                        result.Add(right[rightPinter]);
                        rightPinter++;
                    }
                }
                else
                {
                    if (rightPinter < right.Count)
                    {
                        result.Add(right[rightPinter]);
                        rightPinter++;
                    }
                    else
                    {
                        result.Add(left[leftPointer]);
                        leftPointer++;
                    }
                }
            }

            return result;
        }
    }
}
