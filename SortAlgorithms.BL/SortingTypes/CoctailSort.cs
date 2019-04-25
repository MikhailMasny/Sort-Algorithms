using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithms.BL
{
    /// <summary>
    /// Шейкерная сортировка.
    /// </summary>
    /// <typeparam name="T">Обобщенный метод сравнения.</typeparam>
    public class CoctailSort<T> : AlgorithmsBase<T> where T: IComparable
    {
        /// <summary>
        /// Метод реализации шейкерная сортировки.
        /// </summary>
        public override void Sort()
        {
            int left = 0;
            int right = Items.Count - 1;

            while(left < right)
            {
                for(int i = left; i < right; i++)
                {
                    if(Items[i].CompareTo(Items[i+1]) == 1)
                    {
                        Swap(i, i + 1);
                    }
                }

                right--;

                for (int i = right; i > left; i--)
                {
                    if(Items[i].CompareTo(Items[i - 1]) == -1)
                    {
                        Swap(i, i - 1);
                    }
                }

                left++;
            }
        }
    }
}
