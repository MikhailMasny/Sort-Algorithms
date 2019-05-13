using System;
using System.Collections.Generic;

namespace SortAlgorithms.BL
{
    /// <summary>
    /// Гномья сортировка.
    /// </summary>
    /// <typeparam name="T">Обобщение.</typeparam>
    public class GnomeSort<T> : AlgorithmsBase<T> where T : IComparable
    {
        /// <summary>
        /// Конструктор с добавлением элементов.
        /// </summary>
        /// <param name="items">Элементы.</param>
        public GnomeSort(IEnumerable<T> items) : base(items) { }

        /// <summary>
        /// Пустой конструктор.
        /// </summary>
        public GnomeSort() { }

        /// <summary>
        /// Метод реализации гномьей сортировки.
        /// </summary>
        protected override void MakeSort()
        {
            var i = 1;
            while(i < Items.Count)
            {
                if(i == 0 || Items[i].CompareTo(Items[i - 1]) != -1)
                {
                    i++;
                }
                else
                {
                    Swap(i, i - 1);
                    i--;
                }
            }
        }
    }
}
