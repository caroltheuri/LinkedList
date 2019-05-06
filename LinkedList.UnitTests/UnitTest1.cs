using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Final_LinkedList.UnitTest
{
    [TestClass]
    public class LinkedListTests
    {
        [TestMethod]
        public void Removeduplicates_Remove_DecreaseNodes()
        {
            var remove = new LinkedList();

            var results = remove.removeDuplicates();

            Assert.IsTrue(results);
        }
    }
}
