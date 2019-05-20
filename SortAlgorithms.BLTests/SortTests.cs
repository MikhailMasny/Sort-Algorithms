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
        public void BaseSortTest()
        {
            // Arrange
            var base_sort = new AlgorithmsBase<int>();

            base_sort.Items.AddRange(Items);

            // Act
            base_sort.Sort();

            // Assest
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], base_sort.Items[i]);
            }
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

        [TestMethod()]
        public void ShellSortTest()
        {
            // Arrange
            var shell = new ShellSort<int>();

            shell.Items.AddRange(Items);

            // Act
            shell.Sort();

            // Assest
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], shell.Items[i]);
            }
        }

        [TestMethod()]
        public void TreeSortTest()
        {
            // Arrange
            var tree = new TreeSort<int>();

            tree.Items.AddRange(Items);

            // Act
            tree.Sort();

            // Assest
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], tree.Items[i]);
            }
        }

        [TestMethod()]
        public void HeapSortTest()
        {
            // Arrange
            var heap = new HeapSort<int>();

            heap.Items.AddRange(Items);

            // Act
            heap.Sort();

            // Assest
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], heap.Items[i]);
            }
        }

        [TestMethod()]
        public void SelectionSortTest()
        {
            // Arrange
            var selection = new SelectionSort<int>();

            selection.Items.AddRange(Items);

            // Act
            selection.Sort();

            // Assest
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], selection.Items[i]);
            }
        }

        [TestMethod()]
        public void GnomeSortTest()
        {
            // Arrange
            var gnome = new GnomeSort<int>();

            gnome.Items.AddRange(Items);

            // Act
            gnome.Sort();

            // Assest
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], gnome.Items[i]);
            }
        }

        [TestMethod()]
        public void MergeSortTest()
        {
            // Arrange
            var merge = new MergeSort<int>();

            merge.Items.AddRange(Items);

            // Act
            merge.Sort();

            // Assest
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], merge.Items[i]);
            }
        }
    }
}