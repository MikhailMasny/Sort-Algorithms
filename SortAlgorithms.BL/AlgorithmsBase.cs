using System;
using System.Collections.Generic;
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
            }
        }
        
        /// <summary>
        /// Базовый метод сортировки.
        /// </summary>
        public virtual void Sort()
        {
            Items.Sort();
        }
    }
}
