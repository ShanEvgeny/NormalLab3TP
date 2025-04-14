using Microsoft.VisualStudio.TestTools.UnitTesting;
using Лаб3нормальнаяТП;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб3нормальнаяТП.Tests
{
    [TestClass()]
    public class SetTests
    {
        [TestMethod()]
        public void PrintTest()
        {
            var set = new Set(new List<int> { 1, 2, 3, 4, -5, 0 });
            Assert.AreEqual("1 2 3 4 -5 0", set.ToString());
        }
        [TestMethod()]
        public void AddNumberTest()
        {
            var set = new Set(new List<int> { 1, 2, 3, 4, -5, 0 });
            set = set + 8;
            Assert.AreEqual("1 2 3 4 -5 0 8", set.ToString());
        }
        [TestMethod()]
        public void SumSetsTest()
        {
            var set1 = new Set(new List<int> { 1, 2, 3, 4, 6 });
            var set2 = new Set(new List<int> { 2, 4, 5, 7 });
            var set = set1 + set2;
            Assert.AreEqual("1 2 3 4 6 5 7", set.ToString());
        }
        [TestMethod()]
        public void DeleteNumberTest()
        {
            var set = new Set(new List<int> { 1, 2, 3, 4, 6 });
            set = set - 3;
            Assert.AreEqual("1 2 4 6", set.ToString());
        }
        [TestMethod()]
        public void DifferenceSetsTest()
        {
            var set1 = new Set(new List<int> { 1, 2, 3, 4, 6 });
            var set2 = new Set(new List<int> { 2, 4, 5, 7 });
            var set = set1 - set2;
            Assert.AreEqual("1 3 6", set.ToString());
        }

        [TestMethod()]
        public void MultiplicationSetsTest()
        {
            var set1 = new Set(new List<int> { 1, 2, 3, 4, 6 });
            var set2 = new Set(new List<int> { 2, 4, 5, 7 });
            var set = set1 * set2;
            Assert.AreEqual("2 4", set.ToString());
        }
    }
}