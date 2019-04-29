using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SortAlgorithms.BL.Tests
{
    [TestClass()]
    public class SortTests
    {
        Random rnd = new Random();
        List<int> Items = new List<int>();
        List<int> Sorted = new List<int>();

        [TestInitialize]
        public void Init()
        {
            Items.Clear();

            for (int i = 0; i < 1000; i++)
            {
                Items.Add(rnd.Next(0, 100));
            }

            Sorted.Clear();
            Sorted.AddRange(Items.ToArray().OrderBy(x => x).ToArray());
        }

        [TestMethod()]
        public void BubbleSortTest()
        {
            // Arrange
            var bubble = new BubbleSort<int>();

            bubble.Items.AddRange(Items);

            // Act
            bubble.Sort();

            // Assest
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], bubble.Items[i]);
            }
        }

        [TestMethod()]
        public void CoctailSortTest()
        {
            // Arrange
            var coctail = new CoctailSort<int>();

            coctail.Items.AddRange(Items);

            // Act
            coctail.Sort();

            // Assest
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], coctail.Items[i]);
            }
        }

        [TestMethod()]
        public void InsertSortTest()
        {
            // Arrange
            var insert = new InsertSort<int>();

            insert.Items.AddRange(Items);
            
            // Act
            insert.Sort();

            // Assest
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], insert.Items[i]);
            }
        }
    }
}