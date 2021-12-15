using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestIndex
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FindIndex_vmassive_Test()
        {
            int[] a = { 4, 33, 6, 3, 7 };
            int element = 6;
            int expected = 2;

            int actual = Index.Index.FindIndex(a, element);

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void FindIndex_netvmassive_Test()
        {
            int[] a = { 4, 33, 6, 3, 7 };
            int element = 8;
            int expected = -1;

            int actual = Index.Index.FindIndex(a, element);

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void FindIndex_2odinakelementavmassive_Test()
        {
            int[] a = { 4, 33, 6, 33, 7 };
            int element = 33;
            int expected = 1;

            int actual = Index.Index.FindIndex(a, element);

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void FindIndex_poiskindexa1elementa_Test()
        {
            int[] a = { 4, 33, 6, 3, 7 };
            int element = 4;
            int expected = 0;

            int actual = Index.Index.FindIndex(a, element);

            Assert.AreEqual(expected, actual);

        }
    }

}
