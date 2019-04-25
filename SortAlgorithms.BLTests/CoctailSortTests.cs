using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SortAlgorithms.BL.Tests
{
    [TestClass()]
    public class CoctailSortTests
    {
        [TestMethod()]
        public void SortTest()
        {
            // Arrange
            var coctail = new CoctailSort<int>();
            var rnd = new Random();
            var items = new List<int>();

            for (int i = 0; i < 1000; i++)
            {
                items.Add(rnd.Next(0, 100));
            }

            coctail.Items.AddRange(items);

            var sorted = items.ToArray().OrderBy(x => x).ToArray();

            // Act
            coctail.Sort();

            // Assest
            for (int i = 0; i < items.Count; i++)
            {
                Assert.AreEqual(sorted[i], coctail.Items[i]);
            }
        }
    }
}