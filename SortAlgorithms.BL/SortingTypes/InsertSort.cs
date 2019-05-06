using System;

namespace SortAlgorithms.BL
{
    /// <summary>
    /// Сортировка вставками.
    /// </summary>
    /// <typeparam name="T">Обобщение.</typeparam>
    public class InsertSort<T> : AlgorithmsBase<T> where T : IComparable
    {
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
