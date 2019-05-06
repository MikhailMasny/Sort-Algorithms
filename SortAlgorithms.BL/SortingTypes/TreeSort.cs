using SortAlgorithms.BL.DataStructures;
using System;

namespace SortAlgorithms.BL
{
    /// <summary>
    /// Сортировка двоичным деревом.
    /// </summary>
    /// <typeparam name="T">Обобщение.</typeparam>
    public class TreeSort<T> : AlgorithmsBase<T> where T : IComparable
    {
        /// <summary>
        /// Метод реализации сортировки двоичным деревом.
        /// </summary>
        protected override void MakeSort()
        {
            var tree = new Tree<T>(Items);
            var sorted = tree.Inorder();
            Items = sorted;
        }
    }
}
