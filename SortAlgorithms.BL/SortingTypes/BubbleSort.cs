using System;

namespace SortAlgorithms.BL
{
    /// <summary>
    /// Пузырьковая сортировка.
    /// </summary>
    /// <typeparam name="T">Обобщение.</typeparam>
    public class BubbleSort<T> : AlgorithmsBase<T> where T : IComparable
    {
        /// <summary>
        /// Метод реализации пузырьковой сортировки.
        /// </summary>
        protected override void MakeSort()
        {
            var count = Items.Count;

            for (int j = 0; j < count; j++)
            {
                for (int i = 0; i < count - 1 - j; i++)
                {
                    var a = Items[i];
                    var b = Items[i + 1];

                    if (a.CompareTo(b) == 1)
                    {
                        Swap(i, i + 1);

                        ComparisonCount++;
                    }
                }
            }
        }
    }
}
