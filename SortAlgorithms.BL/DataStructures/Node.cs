using System;

namespace SortAlgorithms.BL.DataStructures
{
    /// <summary>
    /// Класс узла.
    /// </summary>
    /// <typeparam name="T">Обобщение.</typeparam>
    class Node<T> : IComparable
        where T : IComparable
    {
        /// <summary>
        /// Данные.
        /// </summary>
        public T Data { get; private set; }

        /// <summary>
        /// Левый узел.
        /// </summary>
        public Node<T> Left { get; private set; }

        /// <summary>
        /// Правый узел.
        /// </summary>
        public Node<T> Right { get; private set; }

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="data">Данные.</param>
        public Node(T data)
        {
            Data = data;
        }

        /// <summary>
        /// Добавление нового элемента.
        /// </summary>
        /// <param name="data">Данные.</param>
        public void Add(T data)
        {
            var node = new Node<T>(data);

            if (node.Data.CompareTo(Data) == -1)
            {
                if (Left == null)
                {
                    Left = node;
                }
                else
                {
                    Left.Add(data);
                }
            }
            else
            {
                if (Right == null)
                {
                    Right = node;
                }
                else
                {
                    Right.Add(data);
                }
            }
        }

        /// <summary>
        /// Метод сравнения.
        /// </summary>
        /// <param name="obj">Объект для сравнение.</param>
        /// <returns>Результат сравнения.</returns>
        public int CompareTo(object obj)
        {
            if (obj is Node<T> item)
            {
                return Data.CompareTo(item);
            }
            else
            {
                throw new ArgumentException("Не совпадение типов");
            }
        }

        /// <summary>
        /// Переопределение базового ToString.
        /// </summary>
        /// <returns>Возвращает новую строку.</returns>
        public override string ToString()
        {
            return Data.ToString();
        }
    }
}
