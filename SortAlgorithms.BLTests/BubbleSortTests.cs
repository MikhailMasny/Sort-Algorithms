using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SortAlgorithms.BL.Tests
{
    [TestClass()]
    public class BubbleSortTests
    {
        [TestMethod()]
        public void SortTest()
        {
            // Arrange
            var bubble = new BubbleSort<int>();
            var rnd = new Random();
            var items = new List<int>();

            for(int i=0; i < 1000; i++)
            {
                items.Add(rnd.Next(0, 100));
            }

            bubble.Items.AddRange(items);

            var sorted = items.ToArray().OrderBy(x => x).ToArray();

            // Act
            bubble.Sort();

            // Assest
            for(int i = 0; i < items.Count; i++)
            {
                Assert.AreEqual(sorted[i], bubble.Items[i]);
            }
        }
    }
}