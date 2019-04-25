using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithms.BL
{
    /// <summary>
    /// Базовый класс алгоритмов.
    /// </summary>
    /// <typeparam name="T">Обобщенный метод сравнения.</typeparam>
    public class AlgorithmsBase<T> where T : IComparable
    {
        public int SwapCount { get; protected set; } = 0;
        public int ComparisonCount { get; protected set; } = 0;

        /// <summary>
        /// Список значений для сортировки.
        /// </summary>
        public List<T> Items { get; set; } = new List<T>();
        protected void Swap(int positionA, int postitonB)
        {
            if(positionA < Items.Count && postitonB < Items.Count)
            {
                var temp = Items[positionA];
                Items[positionA] = Items[postitonB];
                Items[postitonB] = temp;

                SwapCount++;
            }
        }

        /// <summary>
        /// Базовый метод сортировки.
        /// </summary>
        public TimeSpan Sort()
        {
            var timer = new Stopwatch();
            SwapCount = 0;

            timer.Start();
            MakeSort();
            timer.Stop();

            return timer.Elapsed;
        }

        protected virtual void MakeSort()
        {
            Items.Sort();
        }
    }
}
